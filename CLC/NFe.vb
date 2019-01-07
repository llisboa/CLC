Imports Icraft.IcftBase

Public Class NFe

    Public Shared VersoesPermitidas As String = "1.07;1.10;2.00"

    Public Shared Function NFConv() As String()
        Dim Ret As String = "" & _
        "NFE_VERSAO|nfeProc.versao|" & _
        "INFNFE_ID|nfeProc/NFe/infNFe.Id|" & _
        "INFNFE_VERSAO|nfeProc/NFe/infNFe.versao|" & _
        "INFNFE_X509CERTIFICATE|nfeProc/NFe/Signature/KeyInfo/X509Data/X509Certificate|" & _
        "INFNFE_SIGNATUREVALUE|nfeProc/NFe/Signature/SignatureValue|" & _
        "INFNFE_DIGESTVALUE|nfeProc/NFe/Signature/SignedInfo/Reference/DigestValue|" & _
        "DIST_DEST_EMAIL|nfeProc/NFe/infNFe/dest/email|" & _
        "IDE_CUF|nfeProc/NFe/infNFe/ide/cUF{System.Int64}|" & _
        "IDE_CNF|nfeProc/NFe/infNFe/ide/cNF{System.Int64;000000000}|" & _
        "IDE_NATOP|nfeProc/NFe/infNFe/ide/natOp|" & _
        "IDE_INDPAG|nfeProc/NFe/infNFe/ide/indPag{System.Int64}|" & _
        "IDE_MOD|nfeProc/NFe/infNFe/ide/mod|" & _
        "INFNFE_IDE_SERIE|nfeProc/NFe/infNFe/ide/serie{System.Int64}|" & _
        "INFNFE_IDE_NNF|nfeProc/NFe/infNFe/ide/nNF{System.Int64}|" & _
        "IDE_DEMI|nfeProc/NFe/infNFe/ide/dEmi{System.Date}|" & _
        "IDE_DSAIENT|nfeProc/NFe/infNFe/ide/dSaiEnt{System.Date}|" & _
        "IDE_HSAIENT|nfeProc/NFe/infNFe/ide/hSaiEnt|" & _
        "IDE_TPNF|nfeProc/NFe/infNFe/ide/tpNF{System.Int64}|" & _
        "IDE_CMUNFG|nfeProc/NFe/infNFe/ide/cMunFG{System.Int64}|" & _
        "IDE_REFNFE|nfeProc/NFe/infNFe/ide/NFref/refNFe|" & _
        "IDE_TPIMP|nfeProc/NFe/infNFe/ide/tpImp{System.Int64}|" & _
        "IDE_TPEMIS|nfeProc/NFe/infNFe/ide/tpEmis{System.Int64}|" & _
        "IDE_CDV|nfeProc/NFe/infNFe/ide/cDV{System.Int64}|" & _
        "IDE_TPAMB|nfeProc/NFe/infNFe/ide/tpAmb{System.Int64}|" & _
        "IDE_FINNFE|nfeProc/NFe/infNFe/ide/finNFe{System.Int64}|" & _
        "IDE_PROCEMI|nfeProc/NFe/infNFe/ide/procEmi{System.Int64}|" & _
        "IDE_VERPROC|nfeProc/NFe/infNFe/ide/verProc|" & _
        "IDE_DHCONT|nfeProc/NFe/infNFe/ide/dhCont{System.Date;yyyy-MM-ddTHH:mm:ss}|" & _
        "IDE_XJUST|nfeProc/NFe/infNFe/ide/xJust|" & _
        "EMIT_CNPJ|nfeProc/NFe/infNFe/emit/CNPJ|" & _
        "EMIT_CPF|nfeProc/NFe/infNFe/emit/CPF|" & _
        "EMIT_XNOME|nfeProc/NFe/infNFe/emit/xNome|" & _
        "EMIT_XFANT|nfeProc/NFe/infNFe/emit/xFant|" & _
        "ENDEREMIT_EMIT_XLGR|nfeProc/NFe/infNFe/emit/enderEmit/xLgr|" & _
        "ENDEREMIT_EMIT_NRO|nfeProc/NFe/infNFe/emit/enderEmit/nro|" & _
        "ENDEREMIT_EMIT_XCPL|nfeProc/NFe/infNFe/emit/enderEmit/xCpl|" & _
        "ENDEREMIT_EMIT_XBAIRRO|nfeProc/NFe/infNFe/emit/enderEmit/xBairro|" & _
        "ENDEREMIT_EMIT_CMUN|nfeProc/NFe/infNFe/emit/enderEmit/cMun{System.Int64}|" & _
        "ENDEREMIT_EMIT_XMUN|nfeProc/NFe/infNFe/emit/enderEmit/xMun|" & _
        "ENDEREMIT_EMIT_UF|nfeProc/NFe/infNFe/emit/enderEmit/UF|" & _
        "ENDEREMIT_EMIT_CEP|nfeProc/NFe/infNFe/emit/enderEmit/CEP{System.Int64;00000000}|" & _
        "ENDEREMIT_EMIT_CPAIS|nfeProc/NFe/infNFe/emit/enderEmit/cPais{System.Int64}|" & _
        "ENDEREMIT_EMIT_XPAIS|nfeProc/NFe/infNFe/emit/enderEmit/xPais|" & _
        "ENDEREMIT_EMIT_FONE|nfeProc/NFe/infNFe/emit/enderEmit/fone{System.Int64}|" & _
        "EMIT_IE|nfeProc/NFe/infNFe/emit/IE|" & _
        "EMIT_IEST|nfeProc/NFe/infNFe/emit/IEST|" & _
        "EMIT_IM|nfeProc/NFe/infNFe/emit/IM|" & _
        "EMIT_CNAE|nfeProc/NFe/infNFe/emit/CNAE|" & _
        "EMIT_CRT|nfeProc/NFe/infNFe/emit/CRT{System.Int64}|" & _
        "AVULSA_CNPJ|nfeProc/NFe/infNFe/avulsa/CNPJ|" & _
        "AVULSA_XORGAO|nfeProc/NFe/infNFe/avulsa/xOrgao|" & _
        "AVULSA_MATR|nfeProc/NFe/infNFe/avulsa/matr|" & _
        "AVULSA_XAGENTE|nfeProc/NFe/infNFe/avulsa/xAgente|" & _
        "AVULSA_FONE|nfeProc/NFe/infNFe/avulsa/fone{System.Int64}|" & _
        "AVULSA_UF|nfeProc/NFe/infNFe/avulsa/UF|" & _
        "AVULSA_NDAR|nfeProc/NFe/infNFe/avulsa/nDAR|" & _
        "AVULSA_DEMI|nfeProc/NFe/infNFe/avulsa/dEmi{System.Date}|" & _
        "AVULSA_VDAR|nfeProc/NFe/infNFe/avulsa/vDAR{System.Double;0.00}|" & _
        "AVULSA_REPEMI|nfeProc/NFe/infNFe/avulsa/repEmi|" & _
        "AVULSA_DPAG|nfeProc/NFe/infNFe/avulsa/dPag{System.Date}|" & _
        "DEST_CNPJ|nfeProc/NFe/infNFe/dest/CNPJ|" & _
        "DEST_CPF|nfeProc/NFe/infNFe/dest/CPF|" & _
        "DEST_XNOME|nfeProc/NFe/infNFe/dest/xNome|" & _
        "ENDERDEST_DEST_XLGR|nfeProc/NFe/infNFe/dest/enderDest/xLgr|" & _
        "ENDERDEST_DEST_NRO|nfeProc/NFe/infNFe/dest/enderDest/nro|" & _
        "ENDERDEST_DEST_XCPL|nfeProc/NFe/infNFe/dest/enderDest/xCpl|" & _
        "ENDERDEST_DEST_XBAIRRO|nfeProc/NFe/infNFe/dest/enderDest/xBairro|" & _
        "ENDERDEST_DEST_CMUN|nfeProc/NFe/infNFe/dest/enderDest/cMun{System.Int64}|" & _
        "ENDERDEST_DEST_XMUN|nfeProc/NFe/infNFe/dest/enderDest/xMun|" & _
        "ENDERDEST_DEST_UF|nfeProc/NFe/infNFe/dest/enderDest/UF|" & _
        "ENDERDEST_DEST_CEP|nfeProc/NFe/infNFe/dest/enderDest/CEP{System.Int64;00000000}|" & _
        "ENDERDEST_DEST_CPAIS|nfeProc/NFe/infNFe/dest/enderDest/cPais{System.Int64}|" & _
        "ENDERDEST_DEST_XPAIS|nfeProc/NFe/infNFe/dest/enderDest/xPais|" & _
        "ENDERDEST_DEST_FONE|nfeProc/NFe/infNFe/dest/enderDest/fone{System.Int64}|" & _
        "DIST_DEST_IE|nfeProc/NFe/infNFe/dest/IE|" & _
        "DIST_DEST_ISUF|nfeProc/NFe/infNFe/dest/ISUF|" & _
        "RETIRADA_CNPJ|nfeProc/NFe/infNFe/retirada/CNPJ|" & _
        "RETIRADA_CPF|nfeProc/NFe/infNFe/retirada/CPF|" & _
        "RETIRADA_XLGR|nfeProc/NFe/infNFe/retirada/xLgr|" & _
        "RETIRADA_NRO|nfeProc/NFe/infNFe/retirada/nro|" & _
        "RETIRADA_XCPL|nfeProc/NFe/infNFe/retirada/xCpl|" & _
        "RETIRADA_XBAIRRO|nfeProc/NFe/infNFe/retirada/xBairro|" & _
        "RETIRADA_CMUN|nfeProc/NFe/infNFe/retirada/cMun{System.Int64}|" & _
        "RETIRADA_XMUN|nfeProc/NFe/infNFe/retirada/xMun|" & _
        "RETIRADA_UF|nfeProc/NFe/infNFe/retirada/UF|" & _
        "ENTREGA_CNPJ|nfeProc/NFe/infNFe/entrega/CNPJ|" & _
        "ENTREGA_CPF|nfeProc/NFe/infNFe/entrega/CPF|" & _
        "ENTREGA_XLGR|nfeProc/NFe/infNFe/entrega/xLgr|" & _
        "ENTREGA_NRO|nfeProc/NFe/infNFe/entrega/nro|" & _
        "ENTREGA_XCPL|nfeProc/NFe/infNFe/entrega/xCpl|" & _
        "ENTREGA_XBAIRRO|nfeProc/NFe/infNFe/entrega/xBairro|" & _
        "ENTREGA_CMUN|nfeProc/NFe/infNFe/entrega/cMun{System.Int64}|" & _
        "ENTREGA_XMUN|nfeProc/NFe/infNFe/entrega/xMun|" & _
        "ENTREGA_UF|nfeProc/NFe/infNFe/entrega/UF|" & _
        "MED_NLOTE|nfeProc/NFe/infNFe/det/prod/med/nLote|" & _
        "MED_QLOTE|nfeProc/NFe/infNFe/det/prod/med/qLote{System.Double;0.000}|" & _
        "MED_DFAB|nfeProc/NFe/infNFe/det/prod/med/dFab{System.Date}|" & _
        "MED_DVAL|nfeProc/NFe/infNFe/det/prod/med/dVal{System.Date}|" & _
        "MED_VPMC|nfeProc/NFe/infNFe/det/prod/med/vPMC{System.Double;0.00}|" & _
        "ARMA_TPARMA|nfeProc/NFe/infNFe/det/prod/arma/tpArma{System.Int64}|" & _
        "ARMA_NSERIE|nfeProc/NFe/infNFe/det/prod/arma/nSerie{System.Int64}|" & _
        "ARMA_NCANO|nfeProc/NFe/infNFe/det/prod/arma/nCano{System.Int64}|" & _
        "ARMA_DESCR|nfeProc/NFe/infNFe/det/prod/arma/descr|" & _
        "ICMSTOT_VBC|nfeProc/NFe/infNFe/total/ICMSTot/vBC{System.Double;0.00}|" & _
        "ICMSTOT_VICMS|nfeProc/NFe/infNFe/total/ICMSTot/vICMS{System.Double;0.00}|" & _
        "ICMSTOT_VBCST|nfeProc/NFe/infNFe/total/ICMSTot/vBCST{System.Double;0.00}|" & _
        "ICMSTOT_VST|nfeProc/NFe/infNFe/total/ICMSTot/vST{System.Double;0.00}|" & _
        "ICMSTOT_VPROD|nfeProc/NFe/infNFe/total/ICMSTot/vProd{System.Double;0.00}|" & _
        "ICMSTOT_VFRETE|nfeProc/NFe/infNFe/total/ICMSTot/vFrete{System.Double;0.00}|" & _
        "ICMSTOT_VSEG|nfeProc/NFe/infNFe/total/ICMSTot/vSeg{System.Double;0.00}|" & _
        "ICMSTOT_VDESC|nfeProc/NFe/infNFe/total/ICMSTot/vDesc{System.Double;0.00}|" & _
        "ICMSTOT_VII|nfeProc/NFe/infNFe/total/ICMSTot/vII{System.Double;0.00}|" & _
        "ICMSTOT_VIPI|nfeProc/NFe/infNFe/total/ICMSTot/vIPI{System.Double;0.00}|" & _
        "ICMSTOT_VPIS|nfeProc/NFe/infNFe/total/ICMSTot/vPIS{System.Double;0.00}|" & _
        "ICMSTOT_VCOFINS|nfeProc/NFe/infNFe/total/ICMSTot/vCOFINS{System.Double;0.00}|" & _
        "ICMSTOT_VOUTRO|nfeProc/NFe/infNFe/total/ICMSTot/vOutro{System.Double;0.00}|" & _
        "ICMSTOT_VNF|nfeProc/NFe/infNFe/total/ICMSTot/vNF{System.Double;0.00}|" & _
        "ISSQNTOT_VSERV|nfeProc/NFe/infNFe/total/ISSQNtot/vServ{System.Double;0.00}|" & _
        "ISSQNTOT_VBC|nfeProc/NFe/infNFe/total/ISSQNtot/vBC{System.Double;0.00}|" & _
        "ISSQNTOT_VISS|nfeProc/NFe/infNFe/total/ISSQNtot/vISS{System.Double;0.00}|" & _
        "ISSQNTOT_VPIS|nfeProc/NFe/infNFe/total/ISSQNtot/vPIS{System.Double;0.00}|" & _
        "ISSQNTOT_VCOFINS|nfeProc/NFe/infNFe/total/ISSQNtot/vCOFINS{System.Double;0.00}|" & _
        "RETTRIB_VRETPIS|nfeProc/NFe/infNFe/total/retTrib/vRetPIS{System.Double;0.00}|" & _
        "RETTRIB_VRETCOFINS|nfeProc/NFe/infNFe/total/retTrib/vRetCOFINS{System.Double;0.00}|" & _
        "RETTRIB_VRETCSLL|nfeProc/NFe/infNFe/total/retTrib/vRetCSLL{System.Double;0.00}|" & _
        "RETTRIB_VBCIRRF|nfeProc/NFe/infNFe/total/retTrib/vBCIRRF{System.Double;0.00}|" & _
        "RETTRIB_VIRRF|nfeProc/NFe/infNFe/total/retTrib/vIRRF{System.Double;0.00}|" & _
        "RETTRIB_VBCRETPREV|nfeProc/NFe/infNFe/total/retTrib/vBCRetPrev{System.Double;0.00}|" & _
        "RETTRIB_VRETPREV|nfeProc/NFe/infNFe/total/retTrib/vRetPrev{System.Double;0.00}|" & _
        "TRANSP_MODFRETE|nfeProc/NFe/infNFe/transp/modFrete{System.Int64}|" & _
        "TRANSPORTA_CNPJ|nfeProc/NFe/infNFe/transp/transporta/CNPJ|" & _
        "TRANSPORTA_CPF|nfeProc/NFe/infNFe/transp/transporta/CPF|" & _
        "TRANSPORTA_XNOME|nfeProc/NFe/infNFe/transp/transporta/xNome|" & _
        "TRANSPORTA_IE|nfeProc/NFe/infNFe/transp/transporta/IE|" & _
        "TRANSPORTA_XENDER|nfeProc/NFe/infNFe/transp/transporta/xEnder|" & _
        "TRANSPORTA_XMUN|nfeProc/NFe/infNFe/transp/transporta/xMun|" & _
        "TRANSPORTA_UF|nfeProc/NFe/infNFe/transp/transporta/UF|" & _
        "RETTRANSP_VSERV|nfeProc/NFe/infNFe/transp/retTransp/vServ{System.Double;0.00}|" & _
        "RETTRANSP_VBCRET|nfeProc/NFe/infNFe/transp/retTransp/vBCRet{System.Double;0.00}|" & _
        "RETTRANSP_PICMSRET|nfeProc/NFe/infNFe/transp/retTransp/pICMSRet{System.Double;0.00}|" & _
        "RETTRANSP_VICMSRET|nfeProc/NFe/infNFe/transp/retTransp/vICMSRet{System.Double;0.00}|" & _
        "RETTRANSP_CFOP|nfeProc/NFe/infNFe/transp/retTransp/CFOP{System.Int64}|" & _
        "RETTRANSP_CMUNFG|nfeProc/NFe/infNFe/transp/retTransp/cMunFG{System.Int64}|" & _
        "VEICTRANSP_PLACA|nfeProc/NFe/infNFe/transp/veicTransp/placa|" & _
        "VEICTRANSP_UF|nfeProc/NFe/infNFe/transp/veicTransp/UF|" & _
        "VEICTRANSP_RNTC|nfeProc/NFe/infNFe/transp/veicTransp/RNTC|" & _
        "FAT_NFAT|nfeProc/NFe/infNFe/cobr/fat/nFat|" & _
        "FAT_VORIG|nfeProc/NFe/infNFe/cobr/fat/vOrig{System.Double;0.00}|" & _
        "FAT_VDESC|nfeProc/NFe/infNFe/cobr/fat/vDesc{System.Double;0.00}|" & _
        "FAT_VLIQ|nfeProc/NFe/infNFe/cobr/fat/vLiq{System.Double;0.00}|" & _
        "DUP_NDUP|nfeProc/NFe/infNFe/cobr/dup/nDup|" & _
        "DUP_DVENC|nfeProc/NFe/infNFe/cobr/dup/dVenc{System.Date}|" & _
        "DUP_VDUP|nfeProc/NFe/infNFe/cobr/dup/vDup{System.Double;0.00}|" & _
        "INFADIC_INFADFISCO|nfeProc/NFe/infNFe/infAdic/infAdFisco|" & _
        "INFADIC_INFCPL|nfeProc/NFe/infNFe/infAdic/infCpl|" & _
        "OBSCONT_XCAMP|nfeProc/NFe/infNFe/infAdic/obsCont/xCampo|" & _
        "OBSCONT_XTEXT|nfeProc/NFe/infNFe/infAdic/obsCont/xTexto|" & _
        "OBSFISCO_XCAMP|nfeProc/NFe/infNFe/infAdic/obsFisco/xCampo|" & _
        "OBSFISCO_XTEXT|nfeProc/NFe/infNFe/infAdic/obsFisco/xTexto|" & _
        "PROCREF_NPROC|nfeProc/NFe/infNFe/infAdic/procRef/nProc|" & _
        "PROCREF_INDPROC|nfeProc/NFe/infNFe/infAdic/procRef/indProc{System.Int64}|" & _
        "PROCREF_EXPORTA_UFEMBARQ|nfeProc/NFe/infNFe/exporta/UFEmbarq|" & _
        "PROCREF_EXPORTA_XLOCEMBARQ|nfeProc/NFe/infNFe/exporta/xLocEmbarq|" & _
        "COMPRA_XNEMP|nfeProc/NFe/infNFe/compra/xNEmp|" & _
        "COMPRA_XPED|nfeProc/NFe/infNFe/compra/xPed|" & _
        "COMPRA_XCONT|nfeProc/NFe/infNFe/compra/xCont|" & _
        "FORDIA_DIA|nfeProc/NFe/infNFe/cana/forDia/dia{System.Int64}|" & _
        "FORDIA_QTDE|nfeProc/NFe/infNFe/cana/forDia/qtde{System.Double;0.0000000000}|" & _
        "DEDUC_XDED|nfeProc/NFe/infNFe/cana/deduc/xDed|" & _
        "DEDUC_VDED|nfeProc/NFe/infNFe/cana/deduc/vDed{System.Double;0.00}|" & _
        "PROTNFE_VERSAO|nfeProc/protNFe.versao|" & _
        "PROTNFE_INFPROT_TPAMB|nfeProc/protNFe/infProt/tpAmb{System.Int64}|" & _
        "PROTNFE_VERAPLIC|nfeProc/protNFe/infProt/verAplic|" & _
        "PROTNFE_INFPROT_CHNFE|nfeProc/protNFe/infProt/chNFe|" & _
        "PROTNFE_DHRECBTO|nfeProc/protNFe/infProt/dhRecbto{System.Date;yyyy-MM-ddTHH:mm:ss}|" & _
        "PROTNFE_INFPROT_NPROT|nfeProc/protNFe/infProt/nProt{System.Int64}|" & _
        "PROTNFE_INFPROT_DIGVAL|nfeProc/protNFe/infProt/digVal|" & _
        "PROTNFE_INFPROT_CSTAT|nfeProc/protNFe/infProt/cStat{System.Int64}|" & _
        "PROTNFE_INFPROT_ID|nfeProc/protNFe/infProt.Id|" & _
        "PROTNFE_XMOTIVO|nfeProc/protNFe/infProt/xMotivo"
        Return Split(Ret, "|")
    End Function

    Public Shared Function NFIConv() As String()
        Dim Ret As String = "" & _
        "DET_PROD_NITEM|nfeProc/NFe/infNFe/det/nItem{System.Int64}|" & _
        "PROD_CPROD|nfeProc/NFe/infNFe/det/prod/cProd|" & _
        "PROD_CEAN|*nfeProc/NFe/infNFe/det/prod/cEAN|" & _
        "PROD_XPROD|nfeProc/NFe/infNFe/det/prod/xProd|" & _
        "PROD_NCM|nfeProc/NFe/infNFe/det/prod/NCM|" & _
        "PROD_EXTIPI|nfeProc/NFe/infNFe/det/prod/EXTIPI|" & _
        "PROD_GENERO|nfeProc/NFe/infNFe/det/prod/genero{System.Int64}|" & _
        "PROD_CFOP|nfeProc/NFe/infNFe/det/prod/CFOP{System.Int64}|" & _
        "PROD_UCOM|nfeProc/NFe/infNFe/det/prod/uCom|" & _
        "PROD_QCOM|nfeProc/NFe/infNFe/det/prod/qCom{System.Double;0.0000}|" & _
        "PROD_VUNCOM|nfeProc/NFe/infNFe/det/prod/vUnCom{System.Double;0.0000000000}|" & _
        "PROD_VPROD|nfeProc/NFe/infNFe/det/prod/vProd{System.Double;0.00}|" & _
        "PROD_CEANTRIB|*nfeProc/NFe/infNFe/det/prod/cEANTrib|" & _
        "PROD_UTRIB|nfeProc/NFe/infNFe/det/prod/uTrib|" & _
        "PROD_QTRIB|nfeProc/NFe/infNFe/det/prod/qTrib{System.Double;0.0000}|" & _
        "PROD_VUNTRIB|nfeProc/NFe/infNFe/det/prod/vUnTrib{System.Double;0.0000000000}|" & _
        "PROD_VFRETE|nfeProc/NFe/infNFe/det/prod/vFrete{System.Double;0.00}|" & _
        "PROD_VSEG|nfeProc/NFe/infNFe/det/prod/vSeg{System.Double;0.00}|" & _
        "PROD_VDESC|nfeProc/NFe/infNFe/det/prod/vDesc{System.Double;0.00}|" & _
        "PROD_VOUTRO|nfeProc/NFe/infNFe/det/prod/vOutro{System.Double;0.00}|" & _
        "PROD_INDTOT|nfeProc/NFe/infNFe/det/prod/indTot{System.Int64}|" & _
        "PROD_XPED|nfeProc/NFe/infNFe/det/prod/xPed|" & _
        "PROD_NITEMPED|nfeProc/NFe/infNFe/det/prod/nItemPed|" & _
        "DI_NDI|nfeProc/NFe/infNFe/det/prod/DI/nDI|" & _
        "DI_DDI|nfeProc/NFe/infNFe/det/prod/DI/dDI{System.Date}|" & _
        "DI_XLOCDESEMB|nfeProc/NFe/infNFe/det/prod/DI/xLocDesemb|" & _
        "DI_UFDESEMB|nfeProc/NFe/infNFe/det/prod/DI/UFDesemb|" & _
        "DI_DDESEMB|nfeProc/NFe/infNFe/det/prod/DI/dDesemb{System.Date}|" & _
        "DI_CEXPORTADOR|nfeProc/NFe/infNFe/det/prod/DI/cExportador|" & _
        "ADI_NADICAO|nfeProc/NFe/infNFe/det/prod/DI/adi/nAdicao{System.Int64}|" & _
        "ADI_NSEQADIC|nfeProc/NFe/infNFe/det/prod/DI/adi/nSeqAdic{System.Int64}|" & _
        "ADI_CFABRICANTE|nfeProc/NFe/infNFe/det/prod/DI/adi/cFabricante|" & _
        "ADI_VDESCDI|nfeProc/NFe/infNFe/det/prod/DI/adi/vDescDI{System.Double;0.00}|" & _
        "PROD_ADI_XPED|nfeProc/NFe/infNFe/det/prod/arma/xPed|" & _
        "PROD_ADI_NITEMPED|nfeProc/NFe/infNFe/det/prod/arma/nItemPed{System.Int64}|" & _
        "VEICPROD_TPOP|nfeProc/NFe/infNFe/det/prod/veicProd/tpOp{System.Int64}|" & _
        "VEICPROD_CHASSI|nfeProc/NFe/infNFe/det/prod/veicProd/chassi|" & _
        "VEICPROD_CCOR|nfeProc/NFe/infNFe/det/prod/veicProd/cCor|" & _
        "VEICPROD_XCOR|nfeProc/NFe/infNFe/det/prod/veicProd/xCor|" & _
        "VEICPROD_POT|nfeProc/NFe/infNFe/det/prod/veicProd/pot|" & _
        "VEICPROD_CM3|nfeProc/NFe/infNFe/det/prod/veicProd/CM3|" & _
        "VEICPROD_CILIN|nfeProc/NFe/infNFe/det/prod/veicProd/cilin|" & _
        "VEICPROD_PESOL|nfeProc/NFe/infNFe/det/prod/veicProd/pesoL|" & _
        "VEICPROD_PESOB|nfeProc/NFe/infNFe/det/prod/veicProd/pesoB|" & _
        "VEICPROD_NSERIE|nfeProc/NFe/infNFe/det/prod/veicProd/nSerie|" & _
        "VEICPROD_TPCOMB|nfeProc/NFe/infNFe/det/prod/veicProd/tpComb|" & _
        "VEICPROD_NMOTOR|nfeProc/NFe/infNFe/det/prod/veicProd/nMotor|" & _
        "VEICPROD_CMKG|nfeProc/NFe/infNFe/det/prod/veicProd/CMKG|" & _
        "VEICPROD_CMT|nfeProc/NFe/infNFe/det/prod/veicProd/CMT|" & _
        "VEICPROD_DIST|nfeProc/NFe/infNFe/det/prod/veicProd/dist|" & _
        "VEICPROD_RENAVAM|nfeProc/NFe/infNFe/det/prod/veicProd/RENAVAM|" & _
        "VEICPROD_ANOMOD|nfeProc/NFe/infNFe/det/prod/veicProd/anoMod{System.Int64}|" & _
        "VEICPROD_ANOFAB|nfeProc/NFe/infNFe/det/prod/veicProd/anoFab{System.Int64}|" & _
        "VEICPROD_TPPINT|nfeProc/NFe/infNFe/det/prod/veicProd/tpPint|" & _
        "VEICPROD_TPVEIC|nfeProc/NFe/infNFe/det/prod/veicProd/tpVeic{System.Int64}|" & _
        "VEICPROD_ESPVEIC|nfeProc/NFe/infNFe/det/prod/veicProd/espVeic{System.Int64}|" & _
        "VEICPROD_VIN|nfeProc/NFe/infNFe/det/prod/veicProd/VIN|" & _
        "VEICPROD_CONDVEIC|nfeProc/NFe/infNFe/det/prod/veicProd/condVeic{System.Int64}|" & _
        "VEICPROD_CMOD|nfeProc/NFe/infNFe/det/prod/veicProd/cMod{System.Int64}|" & _
        "VEICPROD_CCORDENATRAN|nfeProc/NFe/infNFe/det/prod/veicProd/cCorDENATRAN{System.Int64}|" & _
        "VEICPROD_LOTE|nfeProc/NFe/infNFe/det/prod/veicProd/lote{System.Int64}|" & _
        "VEICPROD_TPREST|nfeProc/NFe/infNFe/det/prod/veicProd/tpRest{System.Int64}|" & _
        "COMB_CPRODANP|nfeProc/NFe/infNFe/det/prod/comb/cProdANP{System.Int64}|" & _
        "COMB_CODIF|nfeProc/NFe/infNFe/det/prod/comb/CODIF{System.Int64}|" & _
        "COMB_QTEMP|nfeProc/NFe/infNFe/det/prod/comb/qTemp{System.Double;0.0000}|" & _
        "COMB_UFCONS|nfeProc/NFe/infNFe/det/prod/comb/UFCons{System.Int64}|" & _
        "CIDE_QBCPROD|nfeProc/NFe/infNFe/det/prod/comb/UFCons/qBCprod{System.Double;0.0000}|" & _
        "CIDE_VALIQPROD|nfeProc/NFe/infNFe/det/prod/comb/UFCons/vAliqProd{System.Double;0.0000}|" & _
        "CIDE_VCIDE|nfeProc/NFe/infNFe/det/prod/comb/UFCons/vCIDE{System.Double;0.00}|" & _
        "COMB_VBCICMS|nfeProc/NFe/infNFe/det/prod/comb/ICMSComb/vBCICMS{System.Double;0.00}|" & _
        "COMB_VICMS|nfeProc/NFe/infNFe/det/prod/comb/ICMSComb/vICMS{System.Double;0.00}|" & _
        "COMB_VBCICMSST|nfeProc/NFe/infNFe/det/prod/comb/ICMSComb/vBCICMSST{System.Double;0.00}|" & _
        "COMB_VICMSST|nfeProc/NFe/infNFe/det/prod/comb/ICMSComb/vICMSST{System.Double;0.00}|" & _
        "COMB_VBCICMSSTDEST|nfeProc/NFe/infNFe/det/prod/comb/ICMSInter/vBCICMSSTDest{System.Double;0.00}|" & _
        "COMB_VICMSSTDEST|nfeProc/NFe/infNFe/det/prod/comb/ICMSInter/vICMSSTDest{System.Double;0.00}|" & _
        "COMB_VBCICMSSTCONS|nfeProc/NFe/infNFe/det/prod/comb/ICMSCons/vBCICMSSTCons{System.Double;0.00}|" & _
        "COMB_VICMSSTCONS|nfeProc/NFe/infNFe/det/prod/comb/ICMSCons/vICMSSTCons{System.Double;0.00}|" & _
        "COMB_ICMSCONS_UFCONS|nfeProc/NFe/infNFe/det/prod/comb/ICMSCons/UFcons{System.Int64}|" & _
        "ICMS00_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/orig{System.Int64}|" & _
        "ICMS10_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/orig{System.Int64}|" & _
        "ICMS20_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/orig{System.Int64}|" & _
        "ICMS30_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/orig{System.Int64}|" & _
        "ICMS40_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS40/orig{System.Int64}|" & _
        "ICMS51_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/orig{System.Int64}|" & _
        "ICMS60_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS60/orig{System.Int64}|" & _
        "ICMS70_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/orig{System.Int64}|" & _
        "ICMS90_ICMS_ORIG|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/orig{System.Int64}|" & _
        "ICMS00_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/CST{System.Int64;00}|" & _
        "ICMS10_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/CST{System.Int64;00}|" & _
        "ICMS20_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/CST{System.Int64;00}|" & _
        "ICMS30_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/CST{System.Int64;00}|" & _
        "ICMS40_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS40/CST{System.Int64;00}|" & _
        "ICMS51_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/CST{System.Int64;00}|" & _
        "ICMS60_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS60/CST{System.Int64;00}|" & _
        "ICMS70_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/CST{System.Int64;00}|" & _
        "ICMS90_ICMS_CST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/CST{System.Int64;00}|" & _
        "ICMS00_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/modBC{System.Int64}|" & _
        "ICMS10_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/modBC{System.Int64}|" & _
        "ICMS20_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/modBC{System.Int64}|" & _
        "ICMS51_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/modBC{System.Int64}|" & _
        "ICMS70_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/modBC{System.Int64}|" & _
        "ICMS90_ICMS_MODBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/modBC{System.Int64}|" & _
        "ICMS20_ICMS_PREDBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/pRedBC{System.Double;0.00}|" & _
        "ICMS51_ICMS_PREDBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/pRedBC{System.Double;0.00}|" & _
        "ICMS70_ICMS_PREDBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/pRedBC{System.Double;0.00}|" & _
        "ICMS90_ICMS_PREDBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/pRedBC{System.Double;0.00}|" & _
        "ICMS00_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/vBC{System.Double;0.00}|" & _
        "ICMS10_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/vBC{System.Double;0.00}|" & _
        "ICMS20_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/vBC{System.Double;0.00}|" & _
        "ICMS51_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/vBC{System.Double;0.00}|" & _
        "ICMS70_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/vBC{System.Double;0.00}|" & _
        "ICMS90_ICMS_VBC|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/vBC{System.Double;0.00}|" & _
        "ICMS00_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/pICMS{System.Double;0.00}|" & _
        "ICMS10_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/pICMS{System.Double;0.00}|" & _
        "ICMS20_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/pICMS{System.Double;0.00}|" & _
        "ICMS51_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/pICMS{System.Double;0.00}|" & _
        "ICMS70_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/pICMS{System.Double;0.00}|" & _
        "ICMS90_ICMS_PICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/pICMS{System.Double;0.00}|" & _
        "ICMS00_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS00/vICMS{System.Double;0.00}|" & _
        "ICMS10_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/vICMS{System.Double;0.00}|" & _
        "ICMS20_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS20/vICMS{System.Double;0.00}|" & _
        "ICMS40_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/vICMS{System.Double;0.00}|" & _
        "ICMS51_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/vICMS{System.Double;0.00}|" & _
        "ICMS70_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/vICMS{System.Double;0.00}|" & _
        "ICMS90_ICMS_VICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/vICMS{System.Double;0.00}|" & _
        "ICMS10_ICMS_MODBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/modBCST{System.Int64}|" & _
        "ICMS20_ICMS_MODBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/modBCST{System.Int64}|" & _
        "ICMS70_ICMS_MODBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/modBCST{System.Int64}|" & _
        "ICMS90_ICMS_MODBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/modBCST{System.Int64}|" & _
        "ICMS10_ICMS_PMVAST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/pMVAST{System.Double;0.00}|" & _
        "ICMS20_ICMS_PMVAST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/pMVAST{System.Double;0.00}|" & _
        "ICMS70_ICMS_PMVAST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/pMVAST{System.Double;0.00}|" & _
        "ICMS90_ICMS_PMVAST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/pMVAST{System.Double;0.00}|" & _
        "ICMS10_ICMS_PREDBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/pRedBCST{System.Double;0.00}|" & _
        "ICMS20_ICMS_PREDBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/pRedBCST{System.Double;0.00}|" & _
        "ICMS70_ICMS_PREDBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/pRedBCST{System.Double;0.00}|" & _
        "ICMS90_ICMS_PREDBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/pRedBCST{System.Double;0.00}|" & _
        "ICMS10_ICMS_VBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/vBCST{System.Double;0.00}|" & _
        "ICMS20_ICMS_VBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/vBCST{System.Double;0.00}|" & _
        "ICMS70_ICMS_VBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/vBCST{System.Double;0.00}|" & _
        "ICMS90_ICMS_VBCST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/vBCST{System.Double;0.00}|" & _
        "ICMS10_ICMS_PICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/pICMSST{System.Double;0.00}|" & _
        "ICMS20_ICMS_PICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/pICMSST{System.Double;0.00}|" & _
        "ICMS70_ICMS_PICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/pICMSST{System.Double;0.00}|" & _
        "ICMS90_ICMS_PICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/pICMSST{System.Double;0.00}|" & _
        "ICMS10_ICMS_VICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS10/vICMSST{System.Double;0.00}|" & _
        "ICMS20_ICMS_VICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS30/vICMSST{System.Double;0.00}|" & _
        "ICMS70_ICMS_VICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS70/vICMSST{System.Double;0.00}|" & _
        "ICMS90_ICMS_VICMSST|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS90/vICMSST{System.Double;0.00}|" & _
        "ICMS60_ICMS_VBCSTRET|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS60/vBCSTRet{System.Double;0.00}|" & _
        "ICMS60_ICMS_VICMSSTRET|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS60/vICMSSTRet{System.Double;0.00}|" & _
        "ICMS40_ICMS_MOTDESICMS|nfeProc/NFe/infNFe/det/imposto/ICMS/ICMS51/motDesICMS{System.Int64}|" & _
        "IPI_CLENQ|nfeProc/NFe/infNFe/det/imposto/IPI/clEnq|" & _
        "IPI_CNPJPROD|nfeProc/NFe/infNFe/det/imposto/IPI/CNPJProd|" & _
        "IPI_CSELO|nfeProc/NFe/infNFe/det/imposto/IPI/cSelo|" & _
        "IPI_QSELO|nfeProc/NFe/infNFe/det/imposto/IPI/qSelo{System.Int64}|" & _
        "IPI_CENQ|nfeProc/NFe/infNFe/det/imposto/IPI/cEnq|" & _
        "IPITRIB_IPI_CST|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/CST|" & _
        "IPINT_IPI_CST|nfeProc/NFe/infNFe/det/imposto/IPI/IPINT/CST|" & _
        "IPITRIB_IPI_VBC|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/vBC{System.Double;0.00}|" & _
        "IPITRIB_IPI_QUNID|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/qUnid{System.Double;0.0000}|" & _
        "IPITRIB_IPI_VUNID|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/vUnid{System.Double;0.0000}|" & _
        "IPITRIB_IPI_PIPI|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/pIPI{System.Double;0.00}|" & _
        "IPITRIB_IPI_VIPI|nfeProc/NFe/infNFe/det/imposto/IPI/IPITrib/vIPI{System.Double;0.00}|" & _
        "II_VBC|nfeProc/NFe/infNFe/det/imposto/II/vBC{System.Double;0.00}|" & _
        "II_VDESPADU|nfeProc/NFe/infNFe/det/imposto/II/vDespAdu{System.Double;0.00}|" & _
        "II_VII|nfeProc/NFe/infNFe/det/imposto/II/vII{System.Double;0.00}|" & _
        "II_VIOF|nfeProc/NFe/infNFe/det/imposto/II/vIOF{System.Double;0.00}|" & _
        "PISALIQ_PIS_CST|nfeProc/NFe/infNFe/det/imposto/PIS/PISAliq/CST{System.Int64;00}|" & _
        "PISQTDE_PIS_CST|nfeProc/NFe/infNFe/det/imposto/PIS/PISQtde/CST{System.Int64;00}|" & _
        "PISNT_PIS_CST|nfeProc/NFe/infNFe/det/imposto/PIS/PISNT/CST{System.Int64;00}|" & _
        "PISOUTR_PIS_CST|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/CST{System.Int64;00}|" & _
        "PISALIQ_PIS_VBC|nfeProc/NFe/infNFe/det/imposto/PIS/PISAliq/vBC{System.Double;0.00}|" & _
        "PISOUTR_PIS_VBC|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/vBC{System.Double;0.00}|" & _
        "PISALIQ_PIS_PPIS|nfeProc/NFe/infNFe/det/imposto/PIS/PISAliq/pPIS{System.Double;0.00}|" & _
        "PISOUTR_PIS_PPIS|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/pPIS{System.Double;0.00}|" & _
        "PISALIQ_PIS_VPIS|nfeProc/NFe/infNFe/det/imposto/PIS/PISAliq/vPIS{System.Double;0.00}|" & _
        "PISQTDE_PIS_VPIS|nfeProc/NFe/infNFe/det/imposto/PIS/PISQtde/vPIS{System.Double;0.00}|" & _
        "PISOUTR_PIS_VPIS|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/vPIS{System.Double;0.00}|" & _
        "PISQTDE_PIS_QBCPROD|nfeProc/NFe/infNFe/det/imposto/PIS/PISQtde/qBCProd{System.Double;0.0000}|" & _
        "PISOUTR_PIS_QBCPROD|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/qBCProd{System.Double;0.0000}|" & _
        "PISQTDE_PIS_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/PIS/PISQtde/vAliqProd{System.Double;0.0000}|" & _
        "PISOUTR_PIS_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/PIS/PISOutr/vAliqProd{System.Double;0.0000}|" & _
        "PISST_PIS_VBC|nfeProc/NFe/infNFe/det/imposto/PISST/vBC{System.Double;0.00}|" & _
        "PISST_PIS_PPIS|nfeProc/NFe/infNFe/det/imposto/PISST/pPIS{System.Double;0.00}|" & _
        "PISST_PIS_QBCPROD|nfeProc/NFe/infNFe/det/imposto/PISST/qBCProd{System.Double;0.0000}|" & _
        "PISST_PIS_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/PISST/vAliqProd{System.Double;0.0000}|" & _
        "PISST_PIS_VPIS|nfeProc/NFe/infNFe/det/imposto/PISST/vPIS{System.Double;0.00}|" & _
        "COFINSALIQ_COFINS_CST|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSAliq/CST{System.Int64;00}|" & _
        "COFINSQTDE_COFINS_CST|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSQtde/CST{System.Int64;00}|" & _
        "COFINSNT_COFINS_CST|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSNT/CST{System.Int64;00}|" & _
        "COFINSOUTR_COFINS_CST|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/CST{System.Int64;00}|" & _
        "COFINSALIQ_COFINS_VBC|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSAliq/vBC{System.Double;0.00}|" & _
        "COFINSOUTR_COFINS_VBC|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/vBC{System.Double;0.00}|" & _
        "COFINSALIQ_COFINS_PCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSAliq/pCOFINS{System.Double;0.00}|" & _
        "COFINSOUTR_COFINS_PCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/pCOFINS{System.Double;0.00}|" & _
        "COFINSQTDE_COFINS_QBCPROD|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSQtde/qBCProd{System.Double;0.0000}|" & _
        "COFINSOUTR_COFINS_QBCPROD|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/qBCProd{System.Double;0.0000}|" & _
        "COFINSQTDE_COFINS_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSQtde/vAliqProd{System.Double;0.0000}|" & _
        "COFINSOUTR_COFINS_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/vAliqProd{System.Double;0.0000}|" & _
        "COFINSALIQ_COFINS_VCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSAliq/vCOFINS{System.Double;0.00}|" & _
        "COFINSQTDE_COFINS_VCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSQtde/vCOFINS{System.Double;0.00}|" & _
        "COFINSOUTR_COFINS_VCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINS/COFINSOutr/vCOFINS{System.Double;0.00}|" & _
        "COFINSST_VBC|nfeProc/NFe/infNFe/det/imposto/COFINSST/vBC{System.Double;0.00}|" & _
        "COFINSST_PCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINSST/pCOFINS{System.Double;0.00}|" & _
        "COFINSST_QBCPROD|nfeProc/NFe/infNFe/det/imposto/COFINSST/qBCProd{System.Double;0.0000}|" & _
        "COFINSST_VALIQPROD|nfeProc/NFe/infNFe/det/imposto/COFINSST/vAliqProd{System.Double;0.0000}|" & _
        "COFINSST_VCOFINS|nfeProc/NFe/infNFe/det/imposto/COFINSST/vCOFINS{System.Double;0.00}|" & _
        "ISSQN_VBC|nfeProc/NFe/infNFe/det/imposto/ISSQN/vBC{System.Double;0.00}|" & _
        "ISSQN_VALIQ|nfeProc/NFe/infNFe/det/imposto/ISSQN/vAliq{System.Double;0.00}|" & _
        "ISSQN_VISSQN|nfeProc/NFe/infNFe/det/imposto/ISSQN/vISSQN{System.Double;0.00}|" & _
        "ISSQN_CMUNFG|nfeProc/NFe/infNFe/det/imposto/ISSQN/cMunFG{System.Int64}|" & _
        "ISSQN_CLISTSERV|nfeProc/NFe/infNFe/det/imposto/ISSQN/cListServ{System.Int64}|" & _
        "ISSQN_CSITTRIB|nfeProc/NFe/infNFe/det/imposto/ISSQN/cSitTrib|" & _
        "PROD_INFADPROD|nfeProc/NFe/infNFe/det/infAdProd|" & _
        "CANA_SAFRA|nfeProc/NFe/infNFe/cana/safra|" & _
        "CANA_REF|nfeProc/NFe/infNFe/cana/ref|" & _
        "CANA_QTOTMES|nfeProc/NFe/infNFe/cana/qTotMes{System.Double;0.0000000000}|" & _
        "CANA_QTOTANT|nfeProc/NFe/infNFe/cana/qTotAnt{System.Double;0.0000000000}|" & _
        "CANA_QTOTGER|nfeProc/NFe/infNFe/cana/qTotGer{System.Double;0.0000000000}|" & _
        "CANA_VFOR|nfeProc/NFe/infNFe/cana/vFor{System.Double;0.00}|" & _
        "CANA_VTOTDED|nfeProc/NFe/infNFe/cana/vTotDed{System.Double;0.00}|" & _
        "CANA_VLIQFOR|nfeProc/NFe/infNFe/cana/vLiqFor{System.Double;0.00}"
        Return Split(Ret, "|")
    End Function





    Public Shared Function NFCConv(ByVal Prefixo As String) As String()
        Dim Ret As String = "" & _
                "CANCNFE_INFCANC_ID|" & Prefixo & "cancNFe/infCanc.Id|" & _
                "CANCNFE_INFCANC_TPAMB|" & Prefixo & "cancNFe/infCanc/tpAmb|" & _
                "CANCNFE_INFCANC_XSERV|" & Prefixo & "cancNFe/infCanc/xServ|" & _
                "CANCNFE_INFCANC_CHNFE|" & Prefixo & "cancNFe/infCanc/chNFe|" & _
                "CANCNFE_INFCANC_NPROT|" & Prefixo & "cancNFe/infCanc/nProt|" & _
                "CANCNFE_INFCANC_XJUST|" & Prefixo & "cancNFe/infCanc/xJust|" & _
                "RETCANCNFE_INFCANC_VERAPLIC|" & Prefixo & "retCancNFe/infCanc/verAplic|" & _
                "RETCANCNFE_INFCANC_CSTAT|" & Prefixo & "retCancNFe/infCanc/cStat|" & _
                "RETCANCNFE_INFCANC_XMOTIVO|" & Prefixo & "retCancNFe/infCanc/xMotivo|" & _
                "RETCANCNFE_INFCANC_CUF|" & Prefixo & "retCancNFe/infCanc/cUF|" & _
                "RETCANCNFE_INFCANC_CHNFE|" & Prefixo & "retCancNFe/infCanc/chNFe|" & _
                "RETCANCNFE_INFCANC_DHRECBTO|" & Prefixo & "retCancNFe/infCanc/dhRecbto{System.Date;yyyy-MM-ddTHH:mm:ss}|" & _
                "RETCANCNFE_INFCANC_NPROT|" & Prefixo & "retCancNFe/infCanc/nProt"
        Return Split(Ret, "|")
    End Function


    Public Shared Function ParamToItemXML(ByVal Lista() As String) As Dictionary(Of String, ItemXML)
        Return AcertaItemXML(Icraft.IcftBase.ParamArrayToDict(Lista))
    End Function

    Class ItemXML
        Public Campo As String = ""
        Public Elem As String = ""
        Public Tipo As String = ""

        Sub New(ByVal Campo As String, ByVal Valor As String)
            Me.Campo = Campo
            If Campo <> "" Then
                Elem = Valor
                Tipo = Icraft.IcftBase.RegexGroup(Valor, "{(.*?)}", 1).Value
                If Tipo <> "" Then
                    Elem = Replace(Elem, "{" & Tipo & "}", "")
                End If
            End If
        End Sub
    End Class

    Shared Function AcertaItemXML(ByVal Dict As Dictionary(Of String, Object)) As Dictionary(Of String, ItemXML)
        Dim Novo As New Dictionary(Of String, ItemXML)
        For Each Chave As String In Dict.Keys
            Novo.Add(Chave, New ItemXML(Chave, Dict(Chave)))
        Next
        Return Novo
    End Function

    Public Shared Function XMLBase() As XDocument
        Return <?xml version="1.0" encoding="UTF-8"?>
               <nfeProc versao="" xmlns="http://www.portalfiscal.inf.br/nfe">
                   <NFe xmlns="http://www.portalfiscal.inf.br/nfe">
                       <infNFe xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" Id="" versao="">
                       </infNFe>
                       <Signature xmlns="http://www.w3.org/2000/09/xmldsig#">
                           <SignedInfo>
                               <CanonicalizationMethod Algorithm="http://www.w3.org/TR/2001/REC-xml-c14n-20010315"/>
                               <SignatureMethod Algorithm="http://www.w3.org/2000/09/xmldsig#rsa-sha1"/>
                               <Reference URI="">
                                   <Transforms>
                                       <Transform Algorithm="http://www.w3.org/2000/09/xmldsig#enveloped-signature"/>
                                       <Transform Algorithm="http://www.w3.org/TR/2001/REC-xml-c14n-20010315"/>
                                   </Transforms>
                                   <DigestMethod Algorithm="http://www.w3.org/2000/09/xmldsig#sha1"/>
                                   <DigestValue></DigestValue>
                               </Reference>
                           </SignedInfo>
                           <SignatureValue>
                           </SignatureValue>
                           <KeyInfo>
                               <X509Data>
                                   <X509Certificate>
                                   </X509Certificate>
                               </X509Data>
                           </KeyInfo>
                       </Signature>
                   </NFe>
                   <protNFe versao="" xmlns="http://www.portalfiscal.inf.br/nfe">
                   </protNFe>
               </nfeProc>
    End Function

    Private Class Espec
        Public Xml As XDocument
        Public NFConv As Dictionary(Of String, ItemXML)
        Public NFIConv As Dictionary(Of String, ItemXML)
    End Class

    Private Shared Function LocalEspec() As Espec
        Dim Local As New Espec
        Local.Xml = XMLBase()
        Local.NFConv = NFe.ParamToItemXML(NFConv())
        Local.NFIConv = NFe.ParamToItemXML(NFIConv())
        Return Local
    End Function

    Public Shared ReadOnly Property ObtemXML(ByVal Nota As System.Data.DataRow, ByVal Itens As System.Data.DataRowCollection, ByVal Reboques As System.Data.DataRowCollection, ByVal Volumes As System.Data.DataRowCollection, ByVal Dups As System.Data.DataRowCollection) As System.Xml.XmlDocument
        Get
            Dim Local As Espec = LocalEspec()
            Dim XmlDoc As New System.Xml.XmlDocument
            XmlDoc.LoadXml("<?xml version=""1.0"" encoding=""UTF-8""?>" & Local.Xml.ToString)
            Return CriaXML(XmlDoc, Local.NFConv, Nota, Local.NFIConv, Itens, Reboques, Volumes, Dups)
        End Get
    End Property



    Private Shared Function CriaXML(ByVal XmlDoc As System.Xml.XmlDocument, ByVal NF As Dictionary(Of String, ItemXML), ByVal Linha As System.Data.DataRow, ByVal NFI As Dictionary(Of String, ItemXML), ByVal LinhasItem As System.Data.DataRowCollection, ByVal Reboques As System.Data.DataRowCollection, ByVal Volumes As System.Data.DataRowCollection, ByVal Dups As System.Data.DataRowCollection) As System.Xml.XmlDocument
        Dim Id As String = ""
        If IsNothing(XmlDoc) Then
            XmlDoc = New System.Xml.XmlDocument
        End If

        For Each ItemElem As ItemXML In From x In NF Select x.Value

            If ItemElem.Campo = "INFADIC_INFADFISCO" Then

                ' INCLUI REBOQUE
                CriaXMLElem(XmlDoc, "nfeProc/NFe/infNFe/transp", "=", "System.String", Nothing, Nothing)
                Dim XMLREBOQUE As Xml.XmlElement = XmlDoc.Item("nfeProc").Item("NFe").Item("infNFe").Item("transp")
                Dim XMLREBOQUEPATH As Xml.XPath.XPathNavigator = XMLREBOQUE.CreateNavigator

                For Each Item As System.Data.DataRow In Reboques
                    Dim ELEMS As XElement = <reboque xmlns="">
                                                <placa><%= Item("PLACA") %></placa>
                                                <UF><%= Item("UF") %></UF>
                                                <RNTC><%= Item("RNTC") %></RNTC>
                                            </reboque>
                    ELEMS = TiraElemsVazios(ELEMS)
                    XMLREBOQUEPATH.AppendChild(ELEMS.ToString)
                Next


                ' INCLUI VOLUME
                CriaXMLElem(XmlDoc, "nfeProc/NFe/infNFe/transp", "=", "System.String", Nothing, Nothing)
                Dim XMLVOL As Xml.XmlElement = XmlDoc.Item("nfeProc").Item("NFe").Item("infNFe").Item("transp")
                Dim XMLVOLPATH As Xml.XPath.XPathNavigator = XMLVOL.CreateNavigator

                For Each Item As System.Data.DataRow In Volumes
                    Dim ELEMS As XElement = <vol xmlns="">
                                                <qVol><%= Item("VOL_QVOL") %></qVol>
                                                <esp><%= Item("VOL_ESP") %></esp>
                                                <marca><%= Item("VOL_MARCA") %></marca>
                                                <nVol><%= Item("VOL_NVOL") %></nVol>
                                                <pesoL><%= Conteudo(Item("VOL_PESOL"), "System.Double;0.000") %></pesoL>
                                                <pesoB><%= Conteudo(Item("VOL_PESOB"), "System.Double;0.000") %></pesoB>
                                            </vol>
                    ELEMS = TiraElemsVazios(ELEMS)

                    XMLVOLPATH.AppendChild(ELEMS.ToString)
                Next

                ' INCLUI DUP
                CriaXMLElem(XmlDoc, "nfeProc/NFe/infNFe/cobr", "= ", "System.String", Nothing, Nothing)
                Dim XMLDUP As Xml.XmlElement = XmlDoc.Item("nfeProc").Item("NFe").Item("infNFe").Item("cobr")
                Dim XMLDUPPATH As Xml.XPath.XPathNavigator = XMLDUP.CreateNavigator

                XMLDUPPATH.AppendChild(<cobr></cobr>)

                For Each Item As System.Data.DataRow In Dups
                    Dim ELEMS As XElement = <dup xmlns="">
                                                <nDup><%= Item("DUP_NDUP") %></nDup>
                                                <dVenc><%= Item("DUP_DVENC") %></dVenc>
                                                <vDup><%= Item("DUP_VDUP") %></vDup>
                                            </dup>
                    ELEMS = TiraElemsVazios(ELEMS)

                    XMLDUPPATH.AppendChild(ELEMS.ToString)
                Next
            End If

            If ItemElem.Campo = "ICMSTOT_VBC" Then
                For Each Item As System.Data.DataRow In LinhasItem
                    For Each ItemElem2 As ItemXML In From x In NFI Select x.Value
                        Dim ELEM As String = Replace(ItemElem2.Elem, "/det/", "/det.nItem=" & Item("SEQ") & "/")
                        CriaXMLElem(XmlDoc, ELEM, ItemElem2.Campo, ItemElem2.Tipo, Item, Nothing)
                    Next
                Next
            End If
            CriaXMLElem(XmlDoc, ItemElem.Elem, ItemElem.Campo, ItemElem.Tipo, Linha, Nothing)
        Next

        CriaXMLElem(XmlDoc, "nfeProc/NFe/Signature/SignedInfo/Reference.URI", "=#" & Linha("INFNFE_ID"), "System.String", Nothing, Nothing)
        Return XmlDoc
    End Function

    Private Shared Sub CriaXMLElem(ByVal xmldoc As System.Xml.XmlDocument, ByVal Elem As String, ByVal Campo As String, ByVal Tipo As String, ByVal Linha As System.Data.DataRow, ByVal ProcurarEm As Object)
        If IsNothing(ProcurarEm) Then
            ProcurarEm = xmldoc
        End If

        Elem = Replace(Elem, "//", "§1")
        Elem = Replace(Elem, "/.", "§2")

        Dim obrig As Boolean = False
        If Elem.StartsWith("*") Then
            obrig = True
            Elem = Mid(Elem, 2)
        End If

        Dim Elems() As String = Split(Elem, "/")

        Dim VALSTR As String = ""
        If Campo.StartsWith("=") Then
            VALSTR = Mid(Campo, 2)
        Else
            VALSTR = Conteudo(Linha(Campo), Tipo)
        End If

        For z As Integer = 0 To Elems.Count - 1
            Dim Item As String = Elems(z)
            Dim ItemAtrib() As String = Split(Item, ".")

            For zz As Integer = 0 To ItemAtrib.Count - 1
                ItemAtrib(zz) = Replace(ItemAtrib(zz), "§1", "/")
                ItemAtrib(zz) = Replace(ItemAtrib(zz), "§2", ".")
            Next

            Dim BUSCA As System.Xml.XmlNodeList = ProcurarEm.GetElementsByTagName(ItemAtrib(0))
            Dim Segs As List(Of System.Xml.XmlNode) = (From X As System.Xml.XmlNode In BUSCA Select X).ToList

            ' procurando segmento especificado por atributo
            Dim Ret As Object = Nothing
            Dim AtribIgual() As String = {}
            If Segs.Count > 0 And ItemAtrib.Count > 1 Then
                AtribIgual = Icraft.IcftBase.Equivalencia(ItemAtrib(1))
                If AtribIgual.Count > 1 Then
                    For Each Seg As Xml.XmlNode In Segs
                        If Not IsNothing(Seg.Attributes(AtribIgual(0))) Then
                            If Seg.Attributes(AtribIgual(0)).Value = AtribIgual(1) Then
                                Ret = Seg
                                Exit For
                            End If
                        End If
                    Next
                    Segs.Clear()
                    Segs.Add(Ret)
                End If
            End If

            If VALSTR <> "" Or obrig Then
                If IsNothing(Segs) OrElse Segs.Count = 0 Or (AtribIgual.Count > 1 And IsNothing(Ret)) Then
                    If z = (Elems.Count - 1) AndAlso ItemAtrib.Count = 1 Then
                        Dim SEG
                        If VALSTR <> "" Then
                            SEG = xmldoc.CreateElement(ItemAtrib(0))
                            Dim SegT As Xml.XmlText = xmldoc.CreateTextNode(VALSTR)
                            SEG.AppendChild(SegT)
                        Else
                            SEG = xmldoc.CreateDocumentFragment
                            SEG.InnerXml = "<" & ItemAtrib(0) & " />"
                        End If

                        ProcurarEm.appendchild(SEG)
                        ProcurarEm = SEG
                    Else
                        Dim Seg As Xml.XmlElement = xmldoc.CreateElement(ItemAtrib(0))
                        ProcurarEm.AppendChild(Seg)
                        ProcurarEm = Seg
                    End If
                Else
                    ProcurarEm = Segs(0)
                End If

                If ItemAtrib.Count > 1 Then
                    Dim DefAtrib() As String = Icraft.IcftBase.Equivalencia(ItemAtrib(1))
                    If DefAtrib.Count = 1 Then
                        ProcurarEm.SetAttribute(ItemAtrib(1), VALSTR)
                    ElseIf IsNothing(Ret) Then
                        ProcurarEm.setattribute(DefAtrib(0), DefAtrib(1))
                    End If
                ElseIf z = (Elems.Count - 1) AndAlso VALSTR <> "" Then
                    CType(ProcurarEm, Xml.XmlElement).RemoveAll()
                    Dim SegT As Xml.XmlText = xmldoc.CreateTextNode(VALSTR)
                    ProcurarEm.AppendChild(SegT)
                End If
            End If
        Next
    End Sub

    Private Shared Function Conteudo(ByVal Dado As Object, ByVal Tipo As String) As String
        If IsDBNull(Dado) Then
            Return ""
        End If
        Dim PARAMS() As String = Split(Tipo & ";", ";")
        Tipo = PARAMS(0)
        If Tipo = "System.Date" Then
            Return Format(Dado, Icraft.IcftBase.NZV(PARAMS(1), "yyyy-MM-dd"))
        ElseIf Tipo = "System.Int64" OrElse Tipo = "System.Int32" OrElse Tipo = "System.Int16" Then
            Dado = Format(Dado, PARAMS(1))
            Return Dado
        ElseIf Tipo = "System.Double" Then
            Dado = Format(Dado, PARAMS(1))
            If Format(0.1) = "0,1" Then
                Dado = Icraft.IcftBase.TrocaTexto(Dado, New Object() {",", "ø", ".", ",", "ø", "."})
            End If
            Return Dado
        End If
        If PARAMS(1) <> "" Then
            Dado = Format(Dado, PARAMS(1))
        End If
        Return Dado
    End Function

    Public Shared Sub ApagaNota(ByVal CIACOD As String, ByVal NOTASERIE As Integer, ByVal NOTANUM As Integer)
        Dim SQL As String = "BEGIN "
        SQL &= "DELETE FROM IM.NF_VOLUME WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :SERIE AND INFNFE_IDE_NNF = :NNF;"
        SQL &= "DELETE FROM IM.NF_REBOQUE WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :SERIE AND INFNFE_IDE_NNF = :NNF;"
        SQL &= "DELETE FROM IM.NF_ITEM WHERE NF_CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :SERIE AND INFNFE_IDE_NNF = :NNF;"
        SQL &= "DELETE FROM IM.NF WHERE CIA_COD = :CIA_COD AND INFNFE_IDE_SERIE = :SERIE AND INFNFE_IDE_NNF = :NNF;END;"
        Icraft.IcftBase.DSGrava(SQL, Login.Strconn, ":CIA_COD", CIACOD, ":SERIE", NOTASERIE, ":NNF", NOTANUM)
    End Sub

    Public Shared Function ObtemVersao(ByVal XML As Object)
        Dim VERS As String = NZ(Icraft.IcftBase.XmlElem(XML, "nfeProc.versao"), "")
        If VERS = "" Then
            VERS = NZ(Icraft.IcftBase.XmlElem(XML, "procCancNFe.versao"), "")
            If VERS = "" Then
                VERS = NZ(Icraft.IcftBase.XmlElem(XML, "retCancNFe.versao"), "")
                If VERS = "" Then
                    VERS = NZ(Icraft.IcftBase.XmlElem(XML, "NFe/infNFe.versao"), "")
                End If
            End If
        End If
        Return VERS
    End Function

    Public Shared Function ObtemOperacao(ByVal XML As Object)
        Dim OPER As String = NZ(Icraft.IcftBase.XmlElem(XML, "procCancNFe/cancNFe/infCanc/xServ"), "")
        If OPER = "" Then
            OPER = NZ(Icraft.IcftBase.XmlElem(XML, "procCancNFe/infCanc/xServ"), "")
        End If
        Return OPER
    End Function

    Public Shared Function ObtemNotaSerie(ByVal XML As Object)
        Dim RET As String = NZ(Icraft.IcftBase.XmlElem(XML, "nfeProc/NFe/infNFe/ide/serie"), "")
        If RET = "" Then
            RET = NZ(Icraft.IcftBase.XmlElem(XML, "NFe/infNFe/ide/serie"), "")
        End If
        Return RET
    End Function

    Public Shared Function OBTEMNOTANUM(ByVal XML)
        Dim RET As String = NZ(Icraft.IcftBase.XmlElem(XML, "nfeProc/NFe/infNFe/ide/nNF"), "")
        If RET = "" Then
            RET = NZ(Icraft.IcftBase.XmlElem(XML, "NFe/infNFe/ide/nNF"), "")
        End If
        Return RET
    End Function

    Public Shared Function ObtemCancNFE(ByVal XML)
        Dim RET As String = Icraft.IcftBase.XmlElem(XML, "procCancNFe/cancNFe/infCanc/chNFe")
        If RET = "" Then
            RET = Icraft.IcftBase.XmlElem(XML, "retCancNFe/infCanc/chNFe")
        End If
        Return RET
    End Function

    Public Shared Function ObtemCnpjEmit(ByVal XML As Object)
        Dim CNPJ As String = NZ(Icraft.IcftBase.XmlElem(XML, "nfeProc/NFe/infNFe/emit/CNPJ"), "")
        If CNPJ = "" Then
            CNPJ = NZ(Icraft.IcftBase.XmlElem(XML, "procCancNFe/NFe/infNFe/emit/CNPJ"), "")
            If CNPJ = "" Then
                CNPJ = NZ(Icraft.IcftBase.XmlElem(XML, "NFe/infNFe/emit/CNPJ"), "")
            End If
        End If
        Return CNPJ
    End Function

    Public Shared Function ObtemCia(ByVal CNPJNFS As String)
        Return DSCarrega("SELECT COD, LOGO FROM IM.CIA WHERE REPLACE(REPLACE(REPLACE(CNPJ,'.',''),'/',''),'-','')='" & CNPJNFS & "'", Login.Strconn)
    End Function

    Public Shared Function TiraElemsVazios(ByVal Elem As XElement) As XElement
        Dim Busca As Object = Elem.FirstNode
        Do While Not IsNothing(Busca)
            If System.Text.RegularExpressions.Regex.Match(Busca.ToString, "(?is)\<(?<tag>.+?)\>\</\<tag>\>").Success Then
                Dim REMO = Busca
                Busca = Busca.nextnode
                REMO.Remove()
            Else
                Busca = Busca.NextNode
            End If
        Loop
        Return Elem
    End Function


    Public Shared Function DSReg(ByVal Lista() As String) As System.Data.DataSet
        Dim Dic As Dictionary(Of String, ItemXML) = ParamToItemXML(Lista)
        Dim Params As New ArrayList
        For Each Chave As String In Dic.Keys
            Params.Add(Chave)
            Params.Add("")
        Next
        Return DSTabCols(Nothing, "", Params)
    End Function


    Public Shared Function CarregaNotaDirDS(ByVal Diretorio As String, Optional ByVal SubDir As Boolean = False) As System.Data.DataSet
        Dim NFConv() As String = NFe.NFConv
        Dim DS As System.Data.DataSet = DSReg(NFConv)
        For Each ARQ As String In ListaDir(Diretorio, "*.XML", SubDir)
            Dim Xml As New System.Xml.XmlDocument
            Xml.Load(ARQ)
            Dim CANC As String = ""
            Try
                CANC = Icraft.IcftBase.XmlElem(Xml, "retCancNFe/infCanc/chNFe")
            Catch
            End Try
            If CANC = "" Then
                Dim PARAMS As New ArrayList
                For Z As Integer = 0 To NFConv.Count - 1 Step 2
                    Try
                        PARAMS.Add(XmlElem(Xml, NFConv(Z + 1)))
                    Catch
                        PARAMS.Add("")
                    End Try
                Next
                DS.Tables(0).Rows.Add(PARAMS.ToArray)
            End If
        Next
        Return DS
    End Function




End Class
