/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esus.cds.transport.generated.thrift.common
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class EnderecoLocalPermanenciaThrift : TBase
  {
    private string _bairro;
    private string _cep;
    private string _codigoIbgeMunicipio;
    private string _complemento;
    private string _nomeLogradouro;
    private string _numero;
    private string _numeroDneUf;
    private string _telReferencial;
    private string _telResidencial;
    private string _tipoLogradouroNumeroDne;
    private bool _stSemNumero;

    public string Bairro
    {
      get
      {
        return _bairro;
      }
      set
      {
        __isset.bairro = true;
        this._bairro = value;
      }
    }

    public string Cep
    {
      get
      {
        return _cep;
      }
      set
      {
        __isset.cep = true;
        this._cep = value;
      }
    }

    public string CodigoIbgeMunicipio
    {
      get
      {
        return _codigoIbgeMunicipio;
      }
      set
      {
        __isset.codigoIbgeMunicipio = true;
        this._codigoIbgeMunicipio = value;
      }
    }

    public string Complemento
    {
      get
      {
        return _complemento;
      }
      set
      {
        __isset.complemento = true;
        this._complemento = value;
      }
    }

    public string NomeLogradouro
    {
      get
      {
        return _nomeLogradouro;
      }
      set
      {
        __isset.nomeLogradouro = true;
        this._nomeLogradouro = value;
      }
    }

    public string Numero
    {
      get
      {
        return _numero;
      }
      set
      {
        __isset.numero = true;
        this._numero = value;
      }
    }

    public string NumeroDneUf
    {
      get
      {
        return _numeroDneUf;
      }
      set
      {
        __isset.numeroDneUf = true;
        this._numeroDneUf = value;
      }
    }

    public string TelReferencial
    {
      get
      {
        return _telReferencial;
      }
      set
      {
        __isset.telReferencial = true;
        this._telReferencial = value;
      }
    }

    public string TelResidencial
    {
      get
      {
        return _telResidencial;
      }
      set
      {
        __isset.telResidencial = true;
        this._telResidencial = value;
      }
    }

    public string TipoLogradouroNumeroDne
    {
      get
      {
        return _tipoLogradouroNumeroDne;
      }
      set
      {
        __isset.tipoLogradouroNumeroDne = true;
        this._tipoLogradouroNumeroDne = value;
      }
    }

    public bool StSemNumero
    {
      get
      {
        return _stSemNumero;
      }
      set
      {
        __isset.stSemNumero = true;
        this._stSemNumero = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool bairro;
      public bool cep;
      public bool codigoIbgeMunicipio;
      public bool complemento;
      public bool nomeLogradouro;
      public bool numero;
      public bool numeroDneUf;
      public bool telReferencial;
      public bool telResidencial;
      public bool tipoLogradouroNumeroDne;
      public bool stSemNumero;
    }

    public EnderecoLocalPermanenciaThrift() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Bairro = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Cep = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              CodigoIbgeMunicipio = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Complemento = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              NomeLogradouro = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Numero = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              NumeroDneUf = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              TelReferencial = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              TelResidencial = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              TipoLogradouroNumeroDne = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Bool) {
              StSemNumero = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("EnderecoLocalPermanenciaThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Bairro != null && __isset.bairro) {
        field.Name = "bairro";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Bairro);
        oprot.WriteFieldEnd();
      }
      if (Cep != null && __isset.cep) {
        field.Name = "cep";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Cep);
        oprot.WriteFieldEnd();
      }
      if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
        field.Name = "codigoIbgeMunicipio";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CodigoIbgeMunicipio);
        oprot.WriteFieldEnd();
      }
      if (Complemento != null && __isset.complemento) {
        field.Name = "complemento";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Complemento);
        oprot.WriteFieldEnd();
      }
      if (NomeLogradouro != null && __isset.nomeLogradouro) {
        field.Name = "nomeLogradouro";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NomeLogradouro);
        oprot.WriteFieldEnd();
      }
      if (Numero != null && __isset.numero) {
        field.Name = "numero";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Numero);
        oprot.WriteFieldEnd();
      }
      if (NumeroDneUf != null && __isset.numeroDneUf) {
        field.Name = "numeroDneUf";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(NumeroDneUf);
        oprot.WriteFieldEnd();
      }
      if (TelReferencial != null && __isset.telReferencial) {
        field.Name = "telReferencial";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TelReferencial);
        oprot.WriteFieldEnd();
      }
      if (TelResidencial != null && __isset.telResidencial) {
        field.Name = "telResidencial";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TelResidencial);
        oprot.WriteFieldEnd();
      }
      if (TipoLogradouroNumeroDne != null && __isset.tipoLogradouroNumeroDne) {
        field.Name = "tipoLogradouroNumeroDne";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TipoLogradouroNumeroDne);
        oprot.WriteFieldEnd();
      }
      if (__isset.stSemNumero) {
        field.Name = "stSemNumero";
        field.Type = TType.Bool;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StSemNumero);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("EnderecoLocalPermanenciaThrift(");
      bool __first = true;
      if (Bairro != null && __isset.bairro) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Bairro: ");
        __sb.Append(Bairro);
      }
      if (Cep != null && __isset.cep) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Cep: ");
        __sb.Append(Cep);
      }
      if (CodigoIbgeMunicipio != null && __isset.codigoIbgeMunicipio) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CodigoIbgeMunicipio: ");
        __sb.Append(CodigoIbgeMunicipio);
      }
      if (Complemento != null && __isset.complemento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Complemento: ");
        __sb.Append(Complemento);
      }
      if (NomeLogradouro != null && __isset.nomeLogradouro) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NomeLogradouro: ");
        __sb.Append(NomeLogradouro);
      }
      if (Numero != null && __isset.numero) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Numero: ");
        __sb.Append(Numero);
      }
      if (NumeroDneUf != null && __isset.numeroDneUf) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumeroDneUf: ");
        __sb.Append(NumeroDneUf);
      }
      if (TelReferencial != null && __isset.telReferencial) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TelReferencial: ");
        __sb.Append(TelReferencial);
      }
      if (TelResidencial != null && __isset.telResidencial) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TelResidencial: ");
        __sb.Append(TelResidencial);
      }
      if (TipoLogradouroNumeroDne != null && __isset.tipoLogradouroNumeroDne) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TipoLogradouroNumeroDne: ");
        __sb.Append(TipoLogradouroNumeroDne);
      }
      if (__isset.stSemNumero) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StSemNumero: ");
        __sb.Append(StSemNumero);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}