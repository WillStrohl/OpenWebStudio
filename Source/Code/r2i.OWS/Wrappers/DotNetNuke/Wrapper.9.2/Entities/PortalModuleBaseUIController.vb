'<LICENSE>
'   Open Web Studio - http://www.OpenWebStudio.com
'   Copyright (c) 2007-2008
'   by R2Integrated Inc. http://www.R2integrated.com
'      
'   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
'   documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
'   the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
'   to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'    
'   The above copyright notice and this permission notice shall be included in all copies or substantial portions of 
'   the Software.
'   
'   This Software and associated documentation files are subject to the terms and conditions of the Open Web Studio 
'   End User License Agreement and version 2 of the GNU General Public License.
'    
'   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
'   TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
'   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
'   CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
'   DEALINGS IN THE SOFTWARE.
'</LICENSE>
Imports r2i.OWS.Framework.DataAccess
Imports r2i.OWS.Wrapper.DNN.DataAccess.Factories
Namespace Entities
    Public Class PortalModuleBaseUIController
        Implements IPortalModuleBaseUIController


        Public Sub LoadSkin(ByVal portalModuleBase As System.Web.UI.UserControl) Implements IPortalModuleBaseUIController.LoadSkin
            DataAccess.PortalModuleBaseUI.Instance.LoadSkin(CType(portalModuleBase, DotNetNuke.Entities.Modules.PortalModuleBase))
        End Sub

        Public Function GetContainerControl(ByVal iportalModUI As IPortalModuleBaseUI, ByVal moduleId As String) As System.Web.UI.Control Implements IPortalModuleBaseUIController.GetContainerControl
            Return PortalModuleBaseUIFactory.Instance.GetContainerControl(CType(iportalModUI, DotNetNuke.Entities.Modules.PortalModuleBase), moduleId)
        End Function

        Public Function EditUrl() As String Implements IPortalModuleBaseUIController.EditUrl
            Return PortalModuleBaseUIFactory.Instance.EditUrl()
        End Function

        Public Function GetNextActionID() As Integer Implements IPortalModuleBaseUIController.GetNextActionID
            Return PortalModuleBaseUIFactory.Instance.GetNextActionID()
        End Function

        Public Function GetPortalModuleBase1(ByVal control As System.Web.UI.Control) As IPortalModuleBaseUI Implements IPortalModuleBaseUIController.GetPortalModuleBase
            Return PortalModuleBaseUIFactory.GetPortalModuleBase(CType(control, System.Web.UI.UserControl))
        End Function
    End Class
End Namespace

