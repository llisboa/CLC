Public Class frmPesquisas
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click

        Dim V As Integer = Val(TXTCONSULTA.Text)
        Dim SQL As String = ""

        Select Case V

            Case 1

                '1=Conferência de Itens Carregados e Total de Etiquetas

                SQL = "SELECT P.REF, pv.data_bl, pv.viagem_ref, V.VEICULO_COD  FROM IM.PED P, IM.PED_VIAGEM PV, IM.VIAGEM V" & vbCrLf & _
                "WHERE P.REF = pv.ped_ref (+) AND" & vbCrLf & _
                "PV.VIAGEM_REF = V.REF (+) AND P.REF = '" & Icraft.IcftBase.ObtemValorCtl(TXT01PEDIDO) & "'" & vbCrLf

                If TXT01VIAGEM.Text <> "" AndAlso TXT01VIAGEM.Text <> Icraft.IcftBase.ComboNull Then
                    SQL &= "AND V.REF = '" & Split(TXT01VIAGEM.Text, Icraft.IcftBase.ComboSepDefault)(0) & "'" & vbCrLf
                End If

                SQL &= "ORDER BY P.REF, PV.DATA_BL, PV.VIAGEM_REF " & vbCrLf & _
                ";" & vbCrLf & _
                "SELECT PI.PED_REF, PI.ITEM, PEM.VIAGEM_REF, V.VEICULO_COD, PEM.QTD_VOL EMB_QTDVOL, PET.QTD_VOL ETIQ_QTDVOL, PEM.PESO_LIQUIDO EMB_LIQ, PET.PESO_LIQ ETIQ_LIQ, PEM.PESO_BRUTO EMB_BRT, PET.PESO_BRUTO ETIQ_BRT FROM IM.PED_ITEM PI, " & vbCrLf & _
                "(SELECT PED_REF," & vbCrLf & _
                "  PED_ITEM, VIAGEM_REF," & vbCrLf & _
                "  SUM(QTD_VOL) QTD_VOL," & vbCrLf & _
                "  SUM(PESO_LIQUIDO) PESO_LIQUIDO," & vbCrLf & _
                "  SUM(PESO_BRUTO) PESO_BRUTO" & vbCrLf & _
                "FROM IM.PED_ITEM_EMB" & vbCrLf & _
                "GROUP BY PED_REF, PED_ITEM, VIAGEM_REF) PEM, IM.VIAGEM V," & vbCrLf & _
                "(SELECT PED_REF, PED_ITEM, VIAGEM_REF_PED, COUNT(*) QTD_VOL, SUM(PESO_GERENCIA_LIQ) PESO_LIQ, SUM(PESO_GERENCIA_BRUTO) PESO_BRUTO FROM IM.VW_COL_RASTREA_ETIQ" & vbCrLf & _
                "GROUP BY PED_REF, PED_ITEM, VIAGEM_REF_PED) PET" & vbCrLf & _
                "WHERE " & vbCrLf & _
                "PI.PED_REF = PEM.PED_REF(+) AND" & vbCrLf & _
                "PI.ITEM = PEM.PED_ITEM(+) AND" & vbCrLf & _
                "PEM.VIAGEM_REF = V.REF (+) AND" & vbCrLf & _
                "PEM.PED_REF = PET.PED_REF(+) AND" & vbCrLf & _
                "PEM.PED_ITEM = PET.PED_ITEM(+) AND" & vbCrLf & _
                "PEM.VIAGEM_REF = PET.VIAGEM_REF_PED(+) AND" & vbCrLf & _
                "PI.PED_REF = '" & Icraft.IcftBase.ObtemValorCtl(TXT01PEDIDO) & "' AND PEM.VIAGEM_REF = '" & Split(TXT01VIAGEM.Text, Icraft.IcftBase.ComboSepDefault)(0) & "' ORDER BY PED_REF, ITEM"

            Case 2

                '2=Ordens de Venda no Período

                If TXT02INI.Text = "" And TXT02FIM.Text = "" Then
                    MsgBox("Necessário informar período inicial ou final.", MsgBoxStyle.OkOnly)
                    TXT02INI.Focus()
                    Exit Sub
                End If

                SQL = "SELECT ROWNUM REG, VW.ORDEM_VENDA_REF, VW.CLI_NOME, VW.CLI_STREND, VW.DATA_ORDEM, VW.TERMO_PREV_EMB, VW.DESCR_PAGAMENTO, OV.SYS_USUARIO_CRIA USUARIO_CRIA FROM IM.VW_COL_RASTREA_OV VW, IM.ORDEM_VENDA OV" & vbCrLf & _
                "WHERE VW.ORDEM_VENDA_REF = OV.REF (+)" & vbCrLf
                If TXT02OPER.Text <> "" Then
                    SQL &= "AND OV.SYS_USUARIO_CRIA = '" & Trim(TXT02OPER.Text) & "'" & vbCrLf
                End If
                If TXT02INI.Text <> "" Then
                    SQL &= "AND OV.DATA_ORDEM >= TO_DATE('" & TXT02INI.Text & "','DD-MM-YYYY')" & vbCrLf
                End If
                If TXT02FIM.Text <> "" Then
                    SQL &= "AND OV.DATA_ORDEM <= TO_DATE('" & TXT02FIM.Text & "','DD-MM-YYYY')" & vbCrLf
                End If

                'SQL &= vbCrLf & "SELECT * FROM IM.VW_COL_RASTREA_OVI WHERE OV_REF = [:ORDEM_VENDA_REF]"

            Case 3

                '3=Total das Ordens no Período

                If TXT03INI.Text = "" And TXT03FIM.Text = "" Then
                    MsgBox("Necessário informar período inicial ou final.", MsgBoxStyle.OkOnly)
                    TXT03INI.Focus()
                    Exit Sub
                End If

                Dim SQLI As String = "SELECT VW.ORDEM_VENDA_REF, VW.CLI_NOME, VW.CLI_STREND, VW.DATA_ORDEM, VW.TERMO_PREV_EMB, VW.PRAZO," & vbCrLf & _
                "OVI.QTD_NOMINAL, OVI.PED_UNID, OVI.QTD_CARREGAD, OVI.SALDO, OV.SYS_USUARIO_CRIA USUARIO_CRIA FROM IM.VW_COL_RASTREA_OV VW, IM.ORDEM_VENDA OV," & vbCrLf & _
                "(SELECT OV_REF, SUM(NOMINAL_PED_UNID) QTD_NOMINAL, PED_UNID, SUM(EMB_PED_UNID) QTD_CARREGAD, SUM(SALDO) SALDO " & vbCrLf & _
                "FROM IM.VW_COL_RASTREA_OVI GROUP BY OV_REF, PED_UNID) OVI" & vbCrLf & _
                "WHERE VW.ORDEM_VENDA_REF = OV.REF (+) AND" & vbCrLf & _
                "VW.ORDEM_VENDA_REF = OVI.OV_REF (+)" & vbCrLf
                If TXT03OPER.Text <> "" Then
                    SQLI &= "AND OV.SYS_USUARIO_CRIA = '" & Trim(TXT03OPER.Text) & "'" & vbCrLf
                End If
                If TXT03INI.Text <> "" Then
                    SQLI &= "AND OV.DATA_ORDEM >= TO_DATE('" & TXT03INI.Text & "','DD-MM-YYYY')" & vbCrLf
                End If
                If TXT03FIM.Text <> "" Then
                    SQLI &= "AND OV.DATA_ORDEM <= TO_DATE('" & TXT03FIM.Text & "','DD-MM-YYYY')" & vbCrLf
                End If

                SQL = "SELECT * FROM (SELECT SYS_USUARIO_CRIA USUARIO_CRIA FROM IM.ORDEM_VENDA GROUP BY SYS_USUARIO_CRIA ORDER BY 1) WHERE EXISTS(" & SQLI & " AND OV.SYS_USUARIO_CRIA = USUARIO_CRIA)" & vbCrLf & vbCrLf
                SQL &= SQLI
                'SQL &= "AND OV.SYS_USUARIO_CRIA = [:USUARIO_CRIA]" & vbCrLf

            Case 4

                '4=Ranking de Produtos/Especificações

                SQL = "SELECT * FROM (SELECT OVI.PRODUTO_COD, OVI.ESPEC, SUM(OVI.NOMINAL_PED_UNID) QTD_NOMINAL, OVI.PED_UNID FROM IM.VW_COL_RASTREA_OVI OVI, IM.ORDEM_VENDA OV" & vbCrLf & _
                "WHERE OVI.OV_REF = OV.REF (+)" & vbCrLf
                If TXT04INI.Text <> "" Then
                    SQL &= "AND OV.DATA_ORDEM >= TO_DATE('" & TXT04INI.Text & "','DD-MM-YYYY')" & vbCrLf
                End If
                If TXT04FIM.Text <> "" Then
                    SQL &= "AND OV.DATA_ORDEM <= TO_DATE('" & TXT04FIM.Text & "','DD-MM-YYYY')" & vbCrLf
                End If
                SQL &= "GROUP BY OVI.PED_UNID, OVI.PRODUTO_COD, OVI.ESPEC) ORDER BY QTD_NOMINAL DESC"

            Case 5

                '5=Conferência Ordem de Venda CLC x CIEX

                Dim SQLI As String = "SELECT OVI.ORDEM_VENDA_REF, OVI.ITEM, " & vbCrLf & _
                "OVI.PRODUTO_COD CLC_PROD, COVI.DESCR CIEX_PROD," & vbCrLf & _
                "VW.ESPEC CLC_ESPEC, COVI.DIMENSÃO || ' | ' || COVI.QUALIDADE CIEX_ESPEC," & vbCrLf & _
                "OVI.NOMINAL_PED_UNID CLC_NOMINAL, COVI.QTD CIEX_NOMINAL," & vbCrLf & _
                "OVI.CLIENTE_PRECO_UNIT CLC_PRECO, COVI.PREÇO CIEX_PRECO" & vbCrLf & _
                "FROM IM.ORDEM_VENDA_ITEM OVI, CIEX.CONFIRM_VENDA_ITEM COVI, IM.VW_COL_RASTREA_OVI VW" & vbCrLf & _
                "WHERE NVL(OVI.CIEX_ORDEM_REF, OVI.ORDEM_VENDA_REF) = COVI.CONFIRM_VENDA_REF (+) AND" & vbCrLf & _
                "NVL(OVI.CIEX_ITEM, OVI.ITEM) = COVI.ITEM (+) AND" & vbCrLf & _
                "OVI.ORDEM_VENDA_REF = VW.OV_REF (+) AND" & vbCrLf & _
                "OVI.ITEM = VW.OV_ITEM (+)" & vbCrLf
                If CHK05NUMDIF.Checked Then
                    SQLI &= "AND (OVI.NOMINAL_PED_UNID<>COVI.QTD OR OVI.CLIENTE_PRECO_UNIT<>COVI.PREÇO)"
                End If

                SQL = "SELECT OV.REF, OV.DATA_ORDEM CLC_DATA, COV.EMISSÃO_DATA CIEX_DATA, OV.CLIENTE_COD CLC_CLIENTE, COV.COMPRADOR CIEX_CLIENTE," & vbCrLf & _
                "OV.TERMO_PREV_EMB CLC_PREV_EMB, COV.ENTREGA CIEX_PREV_EMB," & vbCrLf & _
                "OV.COND_PAG_COD CLC_COND_PAG, COV.PAG CIEX_COND_PAG," & vbCrLf & _
                "OV.MOEDA_COD CLC_MOEDA, COV.MOEDA CIEX_MOEDA" & vbCrLf & _
                "FROM IM.ORDEM_VENDA OV, CIEX.CONFIRM_VENDA COV WHERE OV.REF LIKE 'BH%' AND " & vbCrLf
                If TXT05QTDREG.Text <> "" Then
                    SQL &= " ROWNUM <= " & TXT05QTDREG.Text & " AND "
                End If
                SQL &= "OV.REF = COV.REF (+) " & vbCrLf
                If CHK05NUMDIF.Checked Then
                    SQL &= " AND EXISTS(" & SQLI & " AND OVI.ORDEM_VENDA_REF=OV.REF)" & vbCrLf
                End If
                SQL &= " ORDER BY OV.REF DESC" & vbCrLf
                'SQL &= vbCrLf
                'SQL &= SQLI & " AND OVI.ORDEM_VENDA_REF = [:REF] ORDER BY OVI.ITEM" & vbCrLf

            Case 6

                '6=Conferência Pedido+Item CLC x CIEX

                Dim SQLI As String = "select PI.PED_REF, PI.ITEM, " & vbCrLf & _
                "PI.PRODUTO_COD CLC_PROD, CPI.PROD CIEX_PROD, " & vbCrLf & _
                "VW.ESPEC CLC_ESPEC, CPI.DIMENSÃO CIEX_ESPEC," & vbCrLf & _
                "PI.NOMINAL_PED_UNID CLC_NOMINAL, CPI.NOMINAL_PED_UNID CIEX_NOMINAL," & vbCrLf & _
                "PI.FORNEC_PRECO_UNIT CLC_PRECO_FORN, CPI.PREÇO_UNITÁRIO_FORNECEDOR CIEX_PRECO_FORN," & vbCrLf & _
                "PI.INTERV1_PRECO_UNIT CLC_PRECO_EXP, CPI.PREÇO_UNITÁRIO_EXP CIEX_PRECO_EXP," & vbCrLf & _
                "PI.INTERV2_PRECO_UNIT CLC_PRECO_IMP, CPI.PREÇO_UNITÁRIO_IMP CIEX_PRECO_IMP" & vbCrLf & _
                "from IM.PED_ITEM PI, CIEX.PED_ITEM CPI, IM.VW_COL_PED_ITEM VW" & vbCrLf & _
                "where NVL(PI.CIEX_PED_REF, PI.PED_REF) = CPI.PED_REF (+) and" & vbCrLf & _
                "NVL(PI.CIEX_ITEM, PI.ITEM) = CPI.ITEM (+) and" & vbCrLf & _
                "PI.PED_REF = VW.PED_REF (+) and" & vbCrLf & _
                "PI.ITEM = VW.ITEM (+)" & vbCrLf
                If CHK06NUMDIF.Checked Then
                    SQLI &= "AND (PI.NOMINAL_PED_UNID<>CPI.NOMINAL_PED_UNID OR PI.FORNEC_PRECO_UNIT<>CPI.PREÇO_UNITÁRIO_FORNECEDOR OR PI.INTERV1_PRECO_UNIT <> CPI.PREÇO_UNITÁRIO_EXP OR PI.INTERV2_PRECO_UNIT <> CPI.PREÇO_UNITÁRIO_IMP)"
                End If


                SQL = "select P.ref, P.DATA_PED CLC_DATA, CP.PED_DATA CIEX_DATA, " & vbCrLf & _
                "P.MOEDA CLC_MOEDA, CP.MOEDA CIEX_MOEDA," & vbCrLf & _
                "P.FORNEC_COD CLC_FORNEC, CP.FORNECEDOR CIEX_FORNEC," & vbCrLf & _
                "P.INTERV1_COD CLC_EXPORT,CP.EXP CIEX_EXPORT," & vbCrLf & _
                "P.INTERV2_COD CLC_IMPORT, CP.IMP CIEX_IMPORT," & vbCrLf & _
                "P.PAGADOR_COD CLC_PAGADOR, CP.PAGADOR CIEX_PAGADOR" & vbCrLf & _
                "from IM.PED P, CIEX.PED CP" & vbCrLf & _
                "where P.ref = CP.ref (+) AND P.REF LIKE 'BH%'" & vbCrLf
                If TXT06QTDREG.Text <> "" Then
                    SQL &= " AND ROWNUM < " & TXT06QTDREG.Text
                End If
                If CHK06NUMDIF.Checked Then
                    SQL &= " AND EXISTS(" & SQLI & " AND PI.PED_REF = P.REF)" & vbCrLf
                End If
                SQL &= " ORDER BY P.REF DESC " & vbCrLf
                'SQL &= vbCrLf
                'SQL &= SQLI & " AND PI.PED_REF = [:REF] ORDER BY PI.ITEM"

            Case 7

                '7=Itens de OV no CLC e não encontrados no CIEX (sem BHOC)

                SQL = "SELECT ROWNUM REG, V.* FROM (SELECT OV.ORDEM_VENDA_REF, OV.ITEM, OV.CIEX_ORDEM_REF, OV.CIEX_ITEM FROM IM.ORDEM_VENDA_ITEM OV, CIEX.CONFIRM_VENDA_ITEM CV " & vbCrLf & _
                "WHERE NVL(OV.CIEX_ORDEM_REF,OV.ORDEM_VENDA_REF) = CV.CONFIRM_VENDA_REF (+) " & vbCrLf & _
                "AND NVL(OV.CIEX_ITEM,OV.ITEM) = CV.ITEM (+) " & vbCrLf & _
                "AND CV.CONFIRM_VENDA_REF IS NULL ORDER BY 1,2) V"

            Case 8

                '8=Itens de OV no CIEX e não encontrados no CLC (sem BHOC)


                SQL = "SELECT ROWNUM REG," & vbCrLf & _
                "  V.*" & vbCrLf & _
                "FROM" & vbCrLf & _
                "  (SELECT CIEX.CONFIRM_VENDA_REF," & vbCrLf & _
                "    CIEX.ITEM" & vbCrLf & _
                "  FROM" & vbCrLf & _
                "    (SELECT CV.CONFIRM_VENDA_REF," & vbCrLf & _
                "      CV.ITEM" & vbCrLf & _
                "    FROM CIEX.CONFIRM_VENDA_ITEM CV" & vbCrLf & _
                "    WHERE NOT UPPER(SUBSTR(CV.CONFIRM_VENDA_REF,1,4)) IN ('BHOC','RJSC','SPSC')" & vbCrLf & _
                "    GROUP BY CV.CONFIRM_VENDA_REF," & vbCrLf & _
                "      CV.ITEM" & vbCrLf & _
                "    ) CIEX," & vbCrLf & _
                "    (SELECT NVL(OV2.CIEX_ORDEM_REF,OV2.ORDEM_VENDA_REF) OV_REF," & vbCrLf & _
                "    NVL(OV2.CIEX_ITEM,OV2.ITEM) OV_ITEM FROM IM.ORDEM_VENDA_ITEM OV2) OV" & vbCrLf & _
                "  WHERE CIEX.CONFIRM_VENDA_REF                   = OV.OV_REF (+)" & vbCrLf & _
                "  AND CIEX.ITEM                                  = OV.OV_ITEM (+)" & vbCrLf & _
                "  AND OV.OV_REF IS NULL" & vbCrLf & _
                "  ORDER BY 1,2" & vbCrLf & _
                "  ) V"

                Dim DS As System.Data.DataSet = Icraft.IcftBase.DSCarrega("SELECT COUNT(*) FROM (" & SQL & ")", Login.Strconn)
                Label31.Text = "Total de Registros: " & DS.Tables(0).Rows(0)(0)

                If TXT05QTDREG.Text <> "" Then
                    SQL &= " WHERE ROWNUM <= " & TXT08QTDREG.Text
                End If

            Case 9

                '9=Itens duplicados no CIEX (sem BHOC)

                SQL = "SELECT ROWNUM REG, V.* FROM (SELECT CONFIRM_VENDA_REF, ITEM, COUNT(*) QTD  FROM (" & vbCrLf & _
                "SELECT CV.CONFIRM_VENDA_REF, CV.ITEM FROM CIEX.CONFIRM_VENDA_ITEM CV" & vbCrLf & _
                "WHERE NOT UPPER(SUBSTR(CV.CONFIRM_VENDA_REF,1,4)) IN 'BHOC' ORDER BY 1,2" & vbCrLf & _
                ") GROUP BY CONFIRM_VENDA_REF, ITEM) V" & vbCrLf & _
                "WHERE(QTD > 1) ORDER BY 1,2"

            Case 10
                '10=Resumo de NFs
                If Trim(TXT10NFS.Text) = "" Then
                    MsgBox("Informe números das notas separados por ponto e vírgula.")
                    Exit Sub
                End If


                SQL = "SELECT ROWNUM REG, CIA_COD, INFNFE_IDE_SERIE SERIE, INFNFE_IDE_NNF NNF, " & vbCrLf & _
                "DEST_XNOME, IDE_DEMI, INFADIC_INFCPL FROM IM.NF WHERE " & vbCrLf & _
                "INFNFE_IDE_NNF IN (" & Replace(TXT10NFS.Text, ";", ", ") & ") ORDER BY 1,2,3"
                '"" & vbCrLf & _
                '"SELECT SEQ, PROD_XPED ORDEM, PROD_NITEMPED ITEM, PROD_XPROD PROD, PROD_INFADPROD DIMENSAO, PROD_QCOM QTD, PROD_UCOM UNID, PROD_VPROD VALOR  FROM IM.NF_ITEM" & vbCrLf & _
                '"WHERE [:CIA_COD] = NF_CIA_COD AND" & vbCrLf & _
                '"[:SERIE] = INFNFE_IDE_SERIE AND" & vbCrLf & _
                '"[:NNF] = INFNFE_IDE_NNF" & vbCrLf & _
                '"" & vbCrLf & _
                '"SELECT ETIQUETA, FORNEC_COD, PRODUTO_COD, ESPEC, PED_REF, PED_ITEM, ORDEM_VENDA_REF OV, ORDEM_VENDA_ITEM OV_ITEM, VIAGEM_REF_PED, VIAGEM_REF_ORDEM, NAVIO, DATA_BL, PESO_GERENCIA_LIQ  FROM IM.VW_COL_RASTREA_ETIQ WHERE" & vbCrLf & _
                '"ORDEM_VENDA_REF = [:ORDEM] AND ORDEM_VENDA_ITEM = [:ITEM]"

            Case 11
                '11=Itens de pedido que existem no CIEX e não existem no CLC
                SQL = "SELECT CPI.PED_REF, " & vbCrLf & _
                "CPI.ITEM " & vbCrLf & _
                "FROM " & vbCrLf & _
                "(SELECT * " & vbCrLf & _
                "FROM CIEX.PED_ITEM " & vbCrLf & _
                "WHERE EXISTS " & vbCrLf & _
                "(SELECT * FROM IM.PED WHERE PED.REF = PED_ITEM.PED_REF " & vbCrLf & _
                ") " & vbCrLf & _
                ") CPI, " & vbCrLf & _
                "(SELECT PED_REF, " & vbCrLf & _
                "ITEM, " & vbCrLf & _
                "NVL(CIEX_PED_REF, PED_REF) X_PED_REF, " & vbCrLf & _
                "NVL(CIEX_ITEM, ITEM) X_PED_ITEM " & vbCrLf & _
                "FROM IM.PED_ITEM " & vbCrLf & _
                ") PI " & vbCrLf & _
                "WHERE CPI.PED_REF = PI.X_PED_REF (+) " & vbCrLf & _
                "AND CPI.ITEM      = PI.X_PED_ITEM (+) " & vbCrLf & _
                "AND PI.PED_REF IS NULL "

            Case 12
                '12=Itens de pedido que existem no CLC e não existem no CIEX
                SQL = "SELECT PI.PED_REF, PI.ITEM " & vbCrLf & _
                "FROM IM.PED_ITEM PI, " & vbCrLf & _
                "CIEX.PED_ITEM CPI, " & vbCrLf & _
                "IM.VW_COL_PED_ITEM VW " & vbCrLf & _
                "WHERE NVL(PI.CIEX_PED_REF, PI.PED_REF) = CPI.PED_REF (+) " & vbCrLf & _
                "AND NVL(PI.CIEX_ITEM, PI.ITEM)         = CPI.ITEM (+) " & vbCrLf & _
                "AND PI.PED_REF                         = VW.PED_REF (+) " & vbCrLf & _
                "AND PI.ITEM                            = VW.ITEM (+) " & vbCrLf & _
                "AND CPI.PED_REF IS NULL " & vbCrLf & _
                "ORDER BY 1,2 "


            Case 13

                '13=Total de Etiquetas cadastradas por Usuários
                SQL = "SELECT MAQUINA, PERIODO, COUNT(ETIQUETA) QTD FROM " & vbCrLf & _
                "(select REGEXP_SUBSTR( E.SYS_LOCAL_CRIA, '[^ []*') MAQUINA, TO_CHAR(E.SYS_MOMENTO_CRIA,'YYYY-MM') PERIODO, ETIQUETA  from IM.ETIQUETA E )" & vbCrLf & _
                "GROUP BY MAQUINA, PERIODO ORDER BY 2,1"

                SQL = Icraft.IcftBase.RefCruz(SQL, "PERIODO", "MAQUINA", "SUM", "QTD", Login.Strconn, "", "")


            Case 14

                '14=Total de Itens de Ordens Cadastrados por Usuários
                SQL = "select MAQUINA, PERIODO, COUNT(ITEM) QTD from " & vbCrLf & _
                "(select REGEXP_SUBSTR( E.SYS_LOCAL_CRIA, '[^ []*') MAQUINA, TO_CHAR(E.SYS_MOMENTO_CRIA,'YYYY-MM') PERIODO, ORDEM_VENDA_REF, ITEM from IM.ORDEM_VENDA_ITEM E )" & vbCrLf & _
                "GROUP BY MAQUINA, PERIODO ORDER BY 2,1"

                SQL = Icraft.IcftBase.RefCruz(SQL, "PERIODO", "MAQUINA", "SUM", "QTD", Login.Strconn, "", "")

            Case 15

                '15=Total de Itens de Pedidos Cadastrados por Usuários
                SQL = "select MAQUINA, PERIODO, COUNT(ITEM) QTD from " & vbCrLf & _
                "(select REGEXP_SUBSTR( E.SYS_LOCAL_CRIA, '[^ []*') MAQUINA, TO_CHAR(E.SYS_MOMENTO_CRIA,'YYYY-MM') PERIODO, PED_REF, ITEM from IM.PED_ITEM E )" & vbCrLf & _
                "GROUP BY MAQUINA, PERIODO ORDER BY 2,1"
                SQL = Icraft.IcftBase.RefCruz(SQL, "PERIODO", "MAQUINA", "SUM", "QTD", Login.Strconn, "", "")

        End Select


        If SQL = "" Then
            CWEB.Text = ""
        Else
            CWEB.StrConn = Login.Strconn
            CWEB.SQL = SQL
            If TXTCONSULTA.SelectedIndex < 10 Then
                CWEB.Titulo = TXTCONSULTA.Text.Substring(2)
            Else
                CWEB.Titulo = TXTCONSULTA.Text.Substring(3)
            End If

            CWEB.Bind()
        End If

    End Sub

    Private Sub frmPesquisas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Icraft.IcftBase.FldFormaTag(Me, "STRCONN", "TXT")
        If TXTCONSULTA.Text = "" Then
            TXTCONSULTA.Text = TXTCONSULTA.Items(0)
        End If
        Icraft.IcftBase.CarregaComboVinc(TXT01PEDIDO, "SELECT REF FROM IM.PED", Login.Strconn)
        Icraft.IcftBase.CarregaComboVinc(TXT01VIAGEM, "SELECT PV.VIAGEM_REF || ' | ' || V.VEICULO_COD || ' | ' || TO_CHAR(PV.DATA_BL,'YYYY-MM-DD') FROM IM.PED_VIAGEM PV, IM.VIAGEM V WHERE PV.VIAGEM_REF = V.REF (+) AND PV.PED_REF = [:TXT01PEDIDO]", Login.Strconn)
        Icraft.IcftBase.CarregaComboVinc(TXT02OPER, "SELECT SYS_USUARIO_CRIA FROM IM.ORDEM_VENDA GROUP BY SYS_USUARIO_CRIA ORDER BY 1", Login.Strconn)
        Icraft.IcftBase.CarregaComboVinc(TXT03OPER, "SELECT SYS_USUARIO_CRIA FROM IM.ORDEM_VENDA GROUP BY SYS_USUARIO_CRIA ORDER BY 1", Login.Strconn)
        Icraft.IcftBase.CarregaComboAssinc(TXT01PEDIDO.Parent.Parent)

    End Sub

    Private Sub TXT01PEDIDO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT01PEDIDO.SelectedIndexChanged
        Icraft.IcftBase.CarregaComboAssinc(TXT01VIAGEM)
    End Sub

    Private Sub TXTCONSULTA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCONSULTA.SelectedIndexChanged
        Dim V As Integer = Val(TXTCONSULTA.Text)
        For z As Integer = 1 To 99
            Dim pnl() As Object = Topo.Controls.Find("G" & Format(z, "00"), False)
            If pnl.Count > 0 Then
                pnl(0).Visible = V = z
            End If
        Next
    End Sub

    Private Sub BTN04SEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04SEM.Click
        Dim D As Date = DateAdd(DateInterval.Day, -Now.DayOfWeek(), Now)
        TXT04INI.Text = Format(D, "dd/MM/yyyy")
        TXT04FIM.Text = Format(DateAdd(DateInterval.Day, 6, D), "dd/MM/yyyy")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub BTN04MES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04MES.Click
        Dim D As Date = DateAdd(DateInterval.Day, -(Now.Day() - 1), Now)
        TXT04INI.Text = Format(D, "dd/MM/yyyy")
        TXT04FIM.Text = Format(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, D)), "dd/MM/yyyy")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub BTN04TRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04TRI.Click
        Dim it As Integer = Int((Now.Month - 1) / 3) * 3 + 1
        Dim D As Date = CDate(Format(Now.Year(), "0000") & "-" & Format(it, "00") & "-01")
        TXT04INI.Text = Format(D, "dd/MM/yyyy")
        TXT04FIM.Text = Format(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 3, D)), "dd/MM/yyyy")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub BTN04SEME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04SEME.Click
        Dim it As Integer = Int((Now.Month - 1) / 6) * 6 + 1
        Dim D As Date = CDate(Format(Now.Year(), "0000") & "-" & Format(it, "00") & "-01")
        TXT04INI.Text = Format(D, "dd/MM/yyyy")
        TXT04FIM.Text = Format(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 6, D)), "dd/MM/yyyy")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub BTN04ANO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04ANO.Click
        Dim D As Date = CDate(Format(Now.Year(), "0000") & "-01-01")
        TXT04INI.Text = Format(D, "dd/MM/yyyy")
        TXT04FIM.Text = Format(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 12, D)), "dd/MM/yyyy")
        btnAtualizar_Click(Nothing, Nothing)
    End Sub
End Class