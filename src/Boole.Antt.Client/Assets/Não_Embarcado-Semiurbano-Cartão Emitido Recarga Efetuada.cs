﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://antt.gov.br/monitriip/v1.0/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://antt.gov.br/monitriip/v1.0/", IsNullable=false)]
public partial class cartaoEmitidoRecargaEfetuada {
    
    private sbyte idLogField;
    
    private string cnpjEmpresaField;
    
    private sbyte codigoCategoriaTransporteField;
    
    private string numeroCartaoField;
    
    private sbyte codigoTipoCartaoField;
    
    private System.DateTime dataVendaField;
    
    private System.DateTime horaVendaField;
    
    private decimal bonusRecargaField;
    
    private decimal valorTotalRecargaField;
    
    private decimal saldoTotalCartaoField;
    
    private cartaoEmitidoRecargaEfetuadaInformacoesPassageiro informacoesPassageiroField;
    
    /// <remarks/>
    public sbyte idLog {
        get {
            return this.idLogField;
        }
        set {
            this.idLogField = value;
        }
    }
    
    /// <remarks/>
    public string cnpjEmpresa {
        get {
            return this.cnpjEmpresaField;
        }
        set {
            this.cnpjEmpresaField = value;
        }
    }
    
    /// <remarks/>
    public sbyte codigoCategoriaTransporte {
        get {
            return this.codigoCategoriaTransporteField;
        }
        set {
            this.codigoCategoriaTransporteField = value;
        }
    }
    
    /// <remarks/>
    public string numeroCartao {
        get {
            return this.numeroCartaoField;
        }
        set {
            this.numeroCartaoField = value;
        }
    }
    
    /// <remarks/>
    public sbyte codigoTipoCartao {
        get {
            return this.codigoTipoCartaoField;
        }
        set {
            this.codigoTipoCartaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dataVenda {
        get {
            return this.dataVendaField;
        }
        set {
            this.dataVendaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime horaVenda {
        get {
            return this.horaVendaField;
        }
        set {
            this.horaVendaField = value;
        }
    }
    
    /// <remarks/>
    public decimal bonusRecarga {
        get {
            return this.bonusRecargaField;
        }
        set {
            this.bonusRecargaField = value;
        }
    }
    
    /// <remarks/>
    public decimal valorTotalRecarga {
        get {
            return this.valorTotalRecargaField;
        }
        set {
            this.valorTotalRecargaField = value;
        }
    }
    
    /// <remarks/>
    public decimal saldoTotalCartao {
        get {
            return this.saldoTotalCartaoField;
        }
        set {
            this.saldoTotalCartaoField = value;
        }
    }
    
    /// <remarks/>
    public cartaoEmitidoRecargaEfetuadaInformacoesPassageiro informacoesPassageiro {
        get {
            return this.informacoesPassageiroField;
        }
        set {
            this.informacoesPassageiroField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://antt.gov.br/monitriip/v1.0/")]
public partial class cartaoEmitidoRecargaEfetuadaInformacoesPassageiro {
    
    private string nomePassageiroField;
    
    private string documentoIdentificacaoPassageiroField;
    
    private string cpfPassageiroField;
    
    private string celularPassageiroField;
    
    /// <remarks/>
    public string nomePassageiro {
        get {
            return this.nomePassageiroField;
        }
        set {
            this.nomePassageiroField = value;
        }
    }
    
    /// <remarks/>
    public string documentoIdentificacaoPassageiro {
        get {
            return this.documentoIdentificacaoPassageiroField;
        }
        set {
            this.documentoIdentificacaoPassageiroField = value;
        }
    }
    
    /// <remarks/>
    public string cpfPassageiro {
        get {
            return this.cpfPassageiroField;
        }
        set {
            this.cpfPassageiroField = value;
        }
    }
    
    /// <remarks/>
    public string celularPassageiro {
        get {
            return this.celularPassageiroField;
        }
        set {
            this.celularPassageiroField = value;
        }
    }
}
