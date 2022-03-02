<%@ Page Language="C#" %>
<%@ Import Namespace="TarCode.Barcode.Control" %>
<%
    LinearWebStream.drawBarcode(Request, Response);
%>
