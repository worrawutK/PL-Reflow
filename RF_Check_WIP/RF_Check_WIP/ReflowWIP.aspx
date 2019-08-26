<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReflowWIP.aspx.vb" Inherits="RF_Check_WIP.ReflowWIP" %>

<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         .styleCell {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
 
    <div>
         <asp:Label ID="lbHeader" runat="server" Font-Size="40pt" ForeColor="#0033CC" >Reflow WIP</asp:Label>
       
     
         <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="20pt" PostBackUrl="~/TCTransferHistory.aspx">Transfer History</asp:LinkButton>
       
     
        <table style="width: 100%;" align="center">
            <tr>
                <td style="width:18%;height:50px;" valign="top">
                      <br />
          
         <br />
                     <asp:RadioButton ID="rbPACKAGE" runat="server" GroupName="SearchWIP" Text="PACKAGE" AutoPostBack="True" Checked="True"/>&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />     <asp:RadioButton ID="rbCARTNO" runat="server" GroupName="SearchWIP"  Text="CART NO." AutoPostBack="True"/>
                   <br />   <asp:RadioButton ID="rbWIPALL" runat="server" AutoPostBack="True" Text="WIP All" GroupName="SearchWIP" /> <br />
                    <asp:Label ID="Label1" runat="server" Text="Package : "></asp:Label> 
  
                   
  
        <asp:DropDownList ID="ddlListItem" runat="server" Width="150px">
        </asp:DropDownList>
                    <br />
                       <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Show Lot No." />
        <asp:SqlDataSource ID="SqlListitem" runat="server" ConnectionString="<%$ ConnectionStrings:DBxConnectionString %>" SelectCommand="SELECT DISTINCT TransactionData.Package FROM TCTransfer INNER JOIN TransactionData ON TCTransfer.LotNo = TransactionData.LotNo
order by TransactionData.Package"></asp:SqlDataSource>
      <br />
                    <asp:Button ID="Button1" runat="server" Text="ค้นหา"/>
                    <br /> <br />
                                    <asp:GridView ID="GridView1" runat="server"  BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" PageSize="15" CellSpacing="1" GridLines="None" AutoGenerateColumns="False">
                 
       
      
                     <Columns>
                         <asp:TemplateField HeaderText="Number">
                                <ItemTemplate>
                                <%# Container.DataItemIndex + 1 %>   
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:BoundField DataField="LotNo" HeaderText="LotNo" Visible="false"/>
                         <asp:BoundField DataField="CartNo" HeaderText="CartNo" />
                         <asp:BoundField DataField="LotStartTime" HeaderText="LotStartTime" Visible="false"/>
                         <asp:BoundField DataField="LotEndTime" HeaderText="LotEndTime" Visible="false"/>
                         <asp:BoundField DataField="Package" HeaderText="Package" />
                         <asp:BoundField DataField="Device" HeaderText="Device"  Visible="false"/>
                     </Columns>
   
   
                     <EmptyDataTemplate>
                        No data
                    </EmptyDataTemplate>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle ForeColor="Black" BackColor="#DEDFDE" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
                 
        <asp:SqlDataSource ID="SqlSearchWIP" runat="server" ConnectionString="<%$ ConnectionStrings:DBxConnectionString %>" >
    <%--        <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="Package" PropertyName="SelectedValue" DefaultValue="" />
            </SelectParameters>--%>
        </asp:SqlDataSource>
                 </td>
                <td rowspan="2" valign="top"> 
                    <asp:Panel ID="Panel1" runat="server" Width ="1200px"  BackColor="Red">
                          <table style="width: 100%;"  border="0">
                        <tr>
                            <td >
                                
                                
                                <uc1:WebUserControl1 ID="CartNo1" runat="server" />
                                
                                
                            </td>
                           <td style="width: 50%;">
                             
                                <uc1:WebUserControl1 ID="CartNo2" runat="server" />                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                
                                
                                <uc1:WebUserControl1 ID="CartNo3" runat="server" />
                                
                                
                            </td>
                            <td>
                                
                                
                                <uc1:WebUserControl1 ID="CartNo4" runat="server" />
                                
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                
                                
                                <uc1:WebUserControl1 ID="CartNo5" runat="server" />
                                
                                
                            </td>
                            <td>
                 
                     <uc1:WebUserControl1 ID="CartNo6" runat="server" />
                 
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                  
                </td>
            
            </tr>
         
            <tr>
                <td valign="top">
    

                </td>
              
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
