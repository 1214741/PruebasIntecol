<%@ Page Language="C#" %>
<%@ Import Namespace="TarCode.Barcode.Control" %>
<%
    MatrixWebStream.drawBarcode(Request, Response);
%>
