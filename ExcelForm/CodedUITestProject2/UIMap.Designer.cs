﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinMenuItem uIExitMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIFileMenuItem.UIExitMenuItem;
            #endregion

            // Click 'File' -> 'Exit' menu item
            Mouse.Click(uIExitMenuItem, new Point(36, 17));
        }
        
        /// <summary>
        /// Integration
        /// </summary>
        public void Integration()
        {
            #region Variable Declarations
            WinMenuItem uIOpenMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIFileMenuItem.UIOpenMenuItem;
            WinEdit uINameEdit = this.UIOpenWindow.UIItemWindow.UITempListItem.UINameEdit;
            WinEdit uINameEdit1 = this.UIOpenWindow.UIItemWindow1.UISample3ListItem.UINameEdit;
            WinTitleBar uIGUITestTitleBar = this.UIGUITestWindow.UIGUITestTitleBar;
            WinRowHeader uIItemRowHeader = this.UIGUITestWindow.UIDataGridView1Window.UIDataGridViewTable.UIRow0Row.UIItemRowHeader;
            WinMenuItem uIRemoveRowMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIEditMenuItem.UIRemoveRowMenuItem;
            WinCell uIItem6610Cell = this.UIGUITestWindow.UIDataGridView1Window.UIDataGridViewTable.UIRow1Row.UIItem6610Cell;
            WinMenuItem uIClearMenuItem = this.UIItemWindow.UIDropDownMenu.UIClearMenuItem;
            WinCell uIItem12Cell = this.UIGUITestWindow.UIDataGridView1Window.UIDataGridViewTable.UIRow2Row.UIItem12Cell;
            WinCell uIItem000449281Cell = this.UIGUITestWindow.UIDataGridView1Window.UIDataGridViewTable.UIRow2Row.UIItem000449281Cell;
            WinMenuItem uIViewMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIViewMenuItem;
            WinMenuItem uIExitMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIFileMenuItem.UIExitMenuItem;
            #endregion

            // Click 'File' -> 'Open' menu item
            Mouse.Click(uIOpenMenuItem, new Point(26, 8));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(28, 6));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit1, new Point(21, 10));

            // Last mouse action was not recorded.

            // Click 'GUI Test' title bar
            Mouse.Click(uIGUITestTitleBar, new Point(166, 8));

            // Click row header
            Mouse.Click(uIItemRowHeader, new Point(17, 11));

            // Click 'Edit' -> 'Remove Row' menu item
            Mouse.Click(uIRemoveRowMenuItem, new Point(30, 1));

            // Click '6610' cell
            Mouse.Click(uIItem6610Cell, new Point(70, 20));

            // Right-Click '6610' cell
            Mouse.Click(uIItem6610Cell, MouseButtons.Right, ModifierKeys.None, new Point(61, 13));

            // Click 'Clear' menu item
            Mouse.Click(uIClearMenuItem, new Point(17, 7));

            // Right-Click '12' cell
            Mouse.Click(uIItem12Cell, MouseButtons.Right, ModifierKeys.None, new Point(49, 6));

            // Click '000449281' cell
            Mouse.Click(uIItem000449281Cell, new Point(80, 5));

            // Click '12' cell
            Mouse.Click(uIItem12Cell, new Point(28, 10));

            // Right-Click '12' cell
            Mouse.Click(uIItem12Cell, MouseButtons.Right, ModifierKeys.None, new Point(28, 10));

            // Click 'Clear' menu item
            Mouse.Click(uIClearMenuItem, new Point(23, 8));

            // Click 'View' menu item
            Mouse.Click(uIViewMenuItem, new Point(24, 5));

            // Click 'File' -> 'Exit' menu item
            Mouse.Click(uIExitMenuItem, new Point(31, 4));
        }
        
        /// <summary>
        /// RecordedMethod2
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WinMenuItem uIOpenMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIFileMenuItem.UIOpenMenuItem;
            WinEdit uINameEdit = this.UIOpenWindow.UIItemWindow.UISampleListItem.UINameEdit;
            WinButton uIOpenButton = this.UIOpenWindow.UIOpenWindow1.UIOpenButton;
            WinRowHeader uIItemRowHeader = this.UIGUITestWindow.UIDataGridView1Window.UIDataGridViewTable.UIRow0Row.UIItemRowHeader;
            WinMenuItem uIRemoveRowMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIEditMenuItem.UIRemoveRowMenuItem;
            WinMenuItem uIExitMenuItem = this.UIGUITestWindow.UIMenuStrip1MenuBar.UIFileMenuItem.UIExitMenuItem;
            #endregion

            // Click 'File' -> 'Open' menu item
            Mouse.Click(uIOpenMenuItem, new Point(29, 9));

            // Click 'Name' text box
            Mouse.Click(uINameEdit, new Point(234, 12));

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(47, 14));

            // Click row header
            Mouse.Click(uIItemRowHeader, new Point(16, 6));

            // Click row header
            Mouse.Click(uIItemRowHeader, new Point(31, 9));

            // Click 'Edit' -> 'Remove Row' menu item
            Mouse.Click(uIRemoveRowMenuItem, new Point(40, 11));

            // Click 'File' -> 'Exit' menu item
            Mouse.Click(uIExitMenuItem, new Point(40, 15));
        }
        
        #region Properties
        public UIGUITestWindow UIGUITestWindow
        {
            get
            {
                if ((this.mUIGUITestWindow == null))
                {
                    this.mUIGUITestWindow = new UIGUITestWindow();
                }
                return this.mUIGUITestWindow;
            }
        }
        
        public UIOpenWindow UIOpenWindow
        {
            get
            {
                if ((this.mUIOpenWindow == null))
                {
                    this.mUIOpenWindow = new UIOpenWindow();
                }
                return this.mUIOpenWindow;
            }
        }
        
        public UIItemWindow2 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow2();
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIGUITestWindow mUIGUITestWindow;
        
        private UIOpenWindow mUIOpenWindow;
        
        private UIItemWindow2 mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIGUITestWindow : WinWindow
    {
        
        public UIGUITestWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "GUI Test";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public UIMenuStrip1MenuBar UIMenuStrip1MenuBar
        {
            get
            {
                if ((this.mUIMenuStrip1MenuBar == null))
                {
                    this.mUIMenuStrip1MenuBar = new UIMenuStrip1MenuBar(this);
                }
                return this.mUIMenuStrip1MenuBar;
            }
        }
        
        public WinTitleBar UIGUITestTitleBar
        {
            get
            {
                if ((this.mUIGUITestTitleBar == null))
                {
                    this.mUIGUITestTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIGUITestTitleBar.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIGUITestTitleBar;
            }
        }
        
        public UIDataGridView1Window UIDataGridView1Window
        {
            get
            {
                if ((this.mUIDataGridView1Window == null))
                {
                    this.mUIDataGridView1Window = new UIDataGridView1Window(this);
                }
                return this.mUIDataGridView1Window;
            }
        }
        #endregion
        
        #region Fields
        private UIMenuStrip1MenuBar mUIMenuStrip1MenuBar;
        
        private WinTitleBar mUIGUITestTitleBar;
        
        private UIDataGridView1Window mUIDataGridView1Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIMenuStrip1MenuBar : WinMenuBar
    {
        
        public UIMenuStrip1MenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "menuStrip1";
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public UIFileMenuItem UIFileMenuItem
        {
            get
            {
                if ((this.mUIFileMenuItem == null))
                {
                    this.mUIFileMenuItem = new UIFileMenuItem(this);
                }
                return this.mUIFileMenuItem;
            }
        }
        
        public UIEditMenuItem UIEditMenuItem
        {
            get
            {
                if ((this.mUIEditMenuItem == null))
                {
                    this.mUIEditMenuItem = new UIEditMenuItem(this);
                }
                return this.mUIEditMenuItem;
            }
        }
        
        public WinMenuItem UIViewMenuItem
        {
            get
            {
                if ((this.mUIViewMenuItem == null))
                {
                    this.mUIViewMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIViewMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "View";
                    this.mUIViewMenuItem.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIViewMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIFileMenuItem mUIFileMenuItem;
        
        private UIEditMenuItem mUIEditMenuItem;
        
        private WinMenuItem mUIViewMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIFileMenuItem : WinMenuItem
    {
        
        public UIFileMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "File";
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIExitMenuItem
        {
            get
            {
                if ((this.mUIExitMenuItem == null))
                {
                    this.mUIExitMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIExitMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Exit";
                    this.mUIExitMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIExitMenuItem.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIExitMenuItem;
            }
        }
        
        public WinMenuItem UIOpenMenuItem
        {
            get
            {
                if ((this.mUIOpenMenuItem == null))
                {
                    this.mUIOpenMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIOpenMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Open";
                    this.mUIOpenMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIOpenMenuItem.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIOpenMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIExitMenuItem;
        
        private WinMenuItem mUIOpenMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIEditMenuItem : WinMenuItem
    {
        
        public UIEditMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Edit";
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIRemoveRowMenuItem
        {
            get
            {
                if ((this.mUIRemoveRowMenuItem == null))
                {
                    this.mUIRemoveRowMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIRemoveRowMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Remove Row";
                    this.mUIRemoveRowMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIRemoveRowMenuItem.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIRemoveRowMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIRemoveRowMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIDataGridView1Window : WinWindow
    {
        
        public UIDataGridView1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "dataGridView1";
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public UIDataGridViewTable UIDataGridViewTable
        {
            get
            {
                if ((this.mUIDataGridViewTable == null))
                {
                    this.mUIDataGridViewTable = new UIDataGridViewTable(this);
                }
                return this.mUIDataGridViewTable;
            }
        }
        #endregion
        
        #region Fields
        private UIDataGridViewTable mUIDataGridViewTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIDataGridViewTable : WinTable
    {
        
        public UIDataGridViewTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public UIRow0Row UIRow0Row
        {
            get
            {
                if ((this.mUIRow0Row == null))
                {
                    this.mUIRow0Row = new UIRow0Row(this);
                }
                return this.mUIRow0Row;
            }
        }
        
        public UIRow1Row UIRow1Row
        {
            get
            {
                if ((this.mUIRow1Row == null))
                {
                    this.mUIRow1Row = new UIRow1Row(this);
                }
                return this.mUIRow1Row;
            }
        }
        
        public UIRow2Row UIRow2Row
        {
            get
            {
                if ((this.mUIRow2Row == null))
                {
                    this.mUIRow2Row = new UIRow2Row(this);
                }
                return this.mUIRow2Row;
            }
        }
        #endregion
        
        #region Fields
        private UIRow0Row mUIRow0Row;
        
        private UIRow1Row mUIRow1Row;
        
        private UIRow2Row mUIRow2Row;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIRow0Row : WinRow
    {
        
        public UIRow0Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinRow.PropertyNames.Value] = "ownr_cd;suprt_pkg_serno;fed_sup_classification;niin;pkup_allow_qty;oh_qty;loctn_n" +
                "o";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public WinRowHeader UIItemRowHeader
        {
            get
            {
                if ((this.mUIItemRowHeader == null))
                {
                    this.mUIItemRowHeader = new WinRowHeader(this);
                    #region Search Criteria
                    this.mUIItemRowHeader.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIItemRowHeader;
            }
        }
        #endregion
        
        #region Fields
        private WinRowHeader mUIItemRowHeader;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIRow1Row : WinRow
    {
        
        public UIRow1Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinRow.PropertyNames.Value] = "52841;UNQ101;6610;000109714;2;0;HOADT1";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem6610Cell
        {
            get
            {
                if ((this.mUIItem6610Cell == null))
                {
                    this.mUIItem6610Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem6610Cell.SearchProperties[WinCell.PropertyNames.Value] = "6610";
                    this.mUIItem6610Cell.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIItem6610Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem6610Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIRow2Row : WinRow
    {
        
        public UIRow2Row(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinRow.PropertyNames.Value] = "52841;UNQ101;7920;000449281;12;12;SMITH01";
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("GUI Test");
            #endregion
        }
        
        #region Properties
        public WinCell UIItem12Cell
        {
            get
            {
                if ((this.mUIItem12Cell == null))
                {
                    this.mUIItem12Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem12Cell.SearchProperties[WinCell.PropertyNames.Value] = "12";
                    this.mUIItem12Cell.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIItem12Cell;
            }
        }
        
        public WinCell UIItem000449281Cell
        {
            get
            {
                if ((this.mUIItem000449281Cell == null))
                {
                    this.mUIItem000449281Cell = new WinCell(this);
                    #region Search Criteria
                    this.mUIItem000449281Cell.SearchProperties[WinCell.PropertyNames.Value] = "000449281";
                    this.mUIItem000449281Cell.WindowTitles.Add("GUI Test");
                    #endregion
                }
                return this.mUIItem000449281Cell;
            }
        }
        #endregion
        
        #region Fields
        private WinCell mUIItem12Cell;
        
        private WinCell mUIItem000449281Cell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIOpenWindow : WinWindow
    {
        
        public UIOpenWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Open";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIOpenWindow1 UIOpenWindow1
        {
            get
            {
                if ((this.mUIOpenWindow1 == null))
                {
                    this.mUIOpenWindow1 = new UIOpenWindow1(this);
                }
                return this.mUIOpenWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIOpenWindow1 mUIOpenWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public UITempListItem UITempListItem
        {
            get
            {
                if ((this.mUITempListItem == null))
                {
                    this.mUITempListItem = new UITempListItem(this);
                }
                return this.mUITempListItem;
            }
        }
        
        public UISampleListItem UISampleListItem
        {
            get
            {
                if ((this.mUISampleListItem == null))
                {
                    this.mUISampleListItem = new UISampleListItem(this);
                }
                return this.mUISampleListItem;
            }
        }
        #endregion
        
        #region Fields
        private UITempListItem mUITempListItem;
        
        private UISampleListItem mUISampleListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UITempListItem : WinListItem
    {
        
        public UITempListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "Temp";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Open");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UISampleListItem : WinListItem
    {
        
        public UISampleListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "Sample";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Open");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public UISample3ListItem UISample3ListItem
        {
            get
            {
                if ((this.mUISample3ListItem == null))
                {
                    this.mUISample3ListItem = new UISample3ListItem(this);
                }
                return this.mUISample3ListItem;
            }
        }
        #endregion
        
        #region Fields
        private UISample3ListItem mUISample3ListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UISample3ListItem : WinListItem
    {
        
        public UISample3ListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "Sample3";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Open");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIOpenWindow1 : WinWindow
    {
        
        public UIOpenWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Open");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Open");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "DropDown";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIDropDownMenu UIDropDownMenu
        {
            get
            {
                if ((this.mUIDropDownMenu == null))
                {
                    this.mUIDropDownMenu = new UIDropDownMenu(this);
                }
                return this.mUIDropDownMenu;
            }
        }
        #endregion
        
        #region Fields
        private UIDropDownMenu mUIDropDownMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.40629.0")]
    public class UIDropDownMenu : WinMenu
    {
        
        public UIDropDownMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "DropDown";
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIClearMenuItem
        {
            get
            {
                if ((this.mUIClearMenuItem == null))
                {
                    this.mUIClearMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIClearMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Clear";
                    #endregion
                }
                return this.mUIClearMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIClearMenuItem;
        #endregion
    }
}
