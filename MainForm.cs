using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SW.Batch.FilletChamfer.Conversion
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private SldWorks m_swApp;
        private ModelDoc2 m_CurDoc;

        private Dictionary<string, Feature> m_dicFilletList;    // 필렛 리스트
        private Dictionary<string, Feature> m_dicChamferList;   // 모따기 리스트

        private bool m_bIstLoadMode = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstb_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            ChgEnableBtn();
        }

        private void btnAnalModel_Click(object sender, EventArgs e)
        {
            m_bIstLoadMode = true;
            try
            {
                // 초기화
                Init();

                // SOLIDWORKS 연결
                if (!ConnetSW())
                    return;

                // 현재 열린 문서 가져오기
                if (!GetModel())
                    return;

                // 필렛과 모따기 정보 가져오기
                if (!GetFilletNChamferList())
                    return;

                // 필렛 리스트 추가
                if (!InsertList(m_dicFilletList, true))
                {
                    XtraMessageBox.Show("필렛 리스트를 추가하는데 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 모따기 리스트 추가
                if (!InsertList(m_dicChamferList, false))
                {
                    XtraMessageBox.Show("모따기 리스트를 추가하는데 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                Debug.Assert(false);
            }
            finally
            {
                m_bIstLoadMode = false;
            }
        }

        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_bIstLoadMode)
                return;

            ListBoxControl lstb = (ListBoxControl)sender;
            Dictionary<string, Feature> dicFeatList = (lstb == lstbFillet ? m_dicFilletList : m_dicChamferList);

            SelFeat(dicFeatList, lstb.SelectedValue.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SimpleButton btnCur = (SimpleButton)sender;

            if (btnCur == btnRemoveFillet)
                BatchRemoveFeat(m_dicFilletList, lstbFillet);
            else
                BatchRemoveFeat(m_dicChamferList, lstbChamfer);

            ChgEnableBtn();
        }

        #region Functions

        private void Init()
        {
            m_dicFilletList = new Dictionary<string, Feature>();
            m_dicChamferList = new Dictionary<string, Feature>();

            lstbFillet.Items.Clear();
            lstbChamfer.Items.Clear();
        }

        private bool ConnetSW()
        {
            try
            {
                if (m_swApp == null)
                {
                    m_swApp = new SldWorks();
                    if (m_swApp == null)
                    {
                        XtraMessageBox.Show("SOLIDWORKS를 연결할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        private bool GetModel()
        {
            try
            {
                m_CurDoc = m_swApp.ActiveDoc;
                if (m_CurDoc == null)
                {
                    XtraMessageBox.Show("현재 열린 문서가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (m_CurDoc.GetType() != (int)swDocumentTypes_e.swDocPART)
                {
                    XtraMessageBox.Show("현재 열린 문서가 파트가 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        private bool GetFilletNChamferList()
        {
            try
            {
                var CurFeatures = m_CurDoc.FeatureManager.GetFeatures(true);
                foreach (Feature CurFeat in CurFeatures)
                {
                    string strFeatName = CurFeat.Name;
                    Debug.Print("피처 이름: " + strFeatName);

                    CurFeat.GetSpecificFeature2();
                    if (CurFeat.GetTypeName2() == "Fillet")
                    {
                        if (!m_dicFilletList.ContainsKey(strFeatName))
                            m_dicFilletList.Add(strFeatName, CurFeat);
                    }
                    else if (CurFeat.GetTypeName2() == "Chamfer")
                    {
                        if (!m_dicChamferList.ContainsKey(strFeatName))
                            m_dicChamferList.Add(strFeatName, CurFeat);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                XtraMessageBox.Show("필렛 및 모따기 정보를 불러오는데 실패하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool InsertList(Dictionary<string, Feature> dicCurList, bool bIsFillet)
        {
            try
            {
                if (dicCurList.Count == 0)
                    return true;

                ListBoxControl lstb = (bIsFillet ? lstbFillet : lstbChamfer);

                foreach (var CurData in dicCurList)
                    lstb.Items.Add(CurData.Key);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        private void SelFeat(Dictionary<string, Feature> dicCurList, string strFeatName)
        {
            if (!dicCurList.ContainsKey(strFeatName))
                return;

            Feature CurFeat = dicCurList[strFeatName];
            CurFeat.Select(false);
        }

        private bool BatchRemoveFeat(Dictionary<string, Feature> dicCurList, ListBoxControl lstbCur)
        {
            try
            {
                for (int i = 0; i < lstbCur.ItemCount; i++)
                {
                    string strFeatName = lstbCur.GetItemText(i);

                    // 피처 제거
                    RemoveFeat(dicCurList, strFeatName);
                }

                dicCurList.Clear();
                lstbCur.Items.Clear();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        // TODO: 작업 해야함.
        private bool SelRemoveFeat(Dictionary<string, Feature> dicCurList, string strFeatName)
        {
            try
            {
                // 피처 제거
                RemoveFeat(dicCurList, strFeatName);

            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        private bool RemoveFeat(Dictionary<string, Feature> dicCurList, string strFeatName)
        {
            try
            {
                SelFeat(dicCurList, strFeatName);
                m_CurDoc.EditDelete();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                Debug.Assert(false);
                return false;
            }
            return true;
        }

        private void ChgEnableBtn()
        {
            if (lstbFillet.Items.Count == 0)
                btnRemoveFillet.Enabled = false;
            else
                btnRemoveFillet.Enabled = true;

            if (lstbChamfer.Items.Count == 0)
                btnRemoveChamfer.Enabled = false;
            else
                btnRemoveChamfer.Enabled = true;
        }

        #endregion

    }
}