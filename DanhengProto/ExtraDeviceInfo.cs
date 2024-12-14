using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F1 RID: 1265
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExtraDeviceInfo : IMessage<ExtraDeviceInfo>, IMessage, IEquatable<ExtraDeviceInfo>, IDeepCloneable<ExtraDeviceInfo>, IBufferMessage
	{
		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x0009AF6B File Offset: 0x0009916B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExtraDeviceInfo> Parser
		{
			get
			{
				return ExtraDeviceInfo._parser;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x0009AF72 File Offset: 0x00099172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExtraDeviceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x0009AF84 File Offset: 0x00099184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExtraDeviceInfo.Descriptor;
			}
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x0009AF8C File Offset: 0x0009918C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeviceInfo()
		{
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x0009AFEC File Offset: 0x000991EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeviceInfo(ExtraDeviceInfo other) : this()
		{
			this.kLMOOMBPHIO_ = other.kLMOOMBPHIO_;
			this.oEOKBLIOGCB_ = other.oEOKBLIOGCB_;
			this.dCNFJNLJEDO_ = other.dCNFJNLJEDO_;
			this.gBNOPNPEAOF_ = other.gBNOPNPEAOF_;
			this.aMOIBMJGKNN_ = other.aMOIBMJGKNN_;
			this.lLCMICAEFGM_ = other.lLCMICAEFGM_;
			this.mAC_ = other.mAC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0009B064 File Offset: 0x00099264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraDeviceInfo Clone()
		{
			return new ExtraDeviceInfo(this);
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0009B06C File Offset: 0x0009926C
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x0009B074 File Offset: 0x00099274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string KLMOOMBPHIO
		{
			get
			{
				return this.kLMOOMBPHIO_;
			}
			set
			{
				this.kLMOOMBPHIO_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x0009B087 File Offset: 0x00099287
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x0009B08F File Offset: 0x0009928F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OEOKBLIOGCB
		{
			get
			{
				return this.oEOKBLIOGCB_;
			}
			set
			{
				this.oEOKBLIOGCB_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x0009B0A2 File Offset: 0x000992A2
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x0009B0AA File Offset: 0x000992AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DCNFJNLJEDO
		{
			get
			{
				return this.dCNFJNLJEDO_;
			}
			set
			{
				this.dCNFJNLJEDO_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x0009B0BD File Offset: 0x000992BD
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x0009B0C5 File Offset: 0x000992C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string GBNOPNPEAOF
		{
			get
			{
				return this.gBNOPNPEAOF_;
			}
			set
			{
				this.gBNOPNPEAOF_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x0009B0D8 File Offset: 0x000992D8
		// (set) Token: 0x060038A1 RID: 14497 RVA: 0x0009B0E0 File Offset: 0x000992E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AMOIBMJGKNN
		{
			get
			{
				return this.aMOIBMJGKNN_;
			}
			set
			{
				this.aMOIBMJGKNN_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x0009B0F3 File Offset: 0x000992F3
		// (set) Token: 0x060038A3 RID: 14499 RVA: 0x0009B0FB File Offset: 0x000992FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LLCMICAEFGM
		{
			get
			{
				return this.lLCMICAEFGM_;
			}
			set
			{
				this.lLCMICAEFGM_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x0009B10E File Offset: 0x0009930E
		// (set) Token: 0x060038A5 RID: 14501 RVA: 0x0009B116 File Offset: 0x00099316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MAC
		{
			get
			{
				return this.mAC_;
			}
			set
			{
				this.mAC_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0009B129 File Offset: 0x00099329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExtraDeviceInfo);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0009B138 File Offset: 0x00099338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExtraDeviceInfo other)
		{
			return other != null && (other == this || (!(this.KLMOOMBPHIO != other.KLMOOMBPHIO) && !(this.OEOKBLIOGCB != other.OEOKBLIOGCB) && !(this.DCNFJNLJEDO != other.DCNFJNLJEDO) && !(this.GBNOPNPEAOF != other.GBNOPNPEAOF) && !(this.AMOIBMJGKNN != other.AMOIBMJGKNN) && !(this.LLCMICAEFGM != other.LLCMICAEFGM) && !(this.MAC != other.MAC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0009B1F4 File Offset: 0x000993F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KLMOOMBPHIO.Length != 0)
			{
				num ^= this.KLMOOMBPHIO.GetHashCode();
			}
			if (this.OEOKBLIOGCB.Length != 0)
			{
				num ^= this.OEOKBLIOGCB.GetHashCode();
			}
			if (this.DCNFJNLJEDO.Length != 0)
			{
				num ^= this.DCNFJNLJEDO.GetHashCode();
			}
			if (this.GBNOPNPEAOF.Length != 0)
			{
				num ^= this.GBNOPNPEAOF.GetHashCode();
			}
			if (this.AMOIBMJGKNN.Length != 0)
			{
				num ^= this.AMOIBMJGKNN.GetHashCode();
			}
			if (this.LLCMICAEFGM.Length != 0)
			{
				num ^= this.LLCMICAEFGM.GetHashCode();
			}
			if (this.MAC.Length != 0)
			{
				num ^= this.MAC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0009B2D7 File Offset: 0x000994D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0009B2DF File Offset: 0x000994DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0009B2E8 File Offset: 0x000994E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KLMOOMBPHIO.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.KLMOOMBPHIO);
			}
			if (this.OEOKBLIOGCB.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.OEOKBLIOGCB);
			}
			if (this.DCNFJNLJEDO.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DCNFJNLJEDO);
			}
			if (this.GBNOPNPEAOF.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.GBNOPNPEAOF);
			}
			if (this.AMOIBMJGKNN.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.AMOIBMJGKNN);
			}
			if (this.LLCMICAEFGM.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.LLCMICAEFGM);
			}
			if (this.MAC.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.MAC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x0009B3F0 File Offset: 0x000995F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KLMOOMBPHIO.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.KLMOOMBPHIO);
			}
			if (this.OEOKBLIOGCB.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OEOKBLIOGCB);
			}
			if (this.DCNFJNLJEDO.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DCNFJNLJEDO);
			}
			if (this.GBNOPNPEAOF.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GBNOPNPEAOF);
			}
			if (this.AMOIBMJGKNN.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AMOIBMJGKNN);
			}
			if (this.LLCMICAEFGM.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LLCMICAEFGM);
			}
			if (this.MAC.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MAC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0009B4E4 File Offset: 0x000996E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExtraDeviceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KLMOOMBPHIO.Length != 0)
			{
				this.KLMOOMBPHIO = other.KLMOOMBPHIO;
			}
			if (other.OEOKBLIOGCB.Length != 0)
			{
				this.OEOKBLIOGCB = other.OEOKBLIOGCB;
			}
			if (other.DCNFJNLJEDO.Length != 0)
			{
				this.DCNFJNLJEDO = other.DCNFJNLJEDO;
			}
			if (other.GBNOPNPEAOF.Length != 0)
			{
				this.GBNOPNPEAOF = other.GBNOPNPEAOF;
			}
			if (other.AMOIBMJGKNN.Length != 0)
			{
				this.AMOIBMJGKNN = other.AMOIBMJGKNN;
			}
			if (other.LLCMICAEFGM.Length != 0)
			{
				this.LLCMICAEFGM = other.LLCMICAEFGM;
			}
			if (other.MAC.Length != 0)
			{
				this.MAC = other.MAC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0009B5BB File Offset: 0x000997BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0009B5C4 File Offset: 0x000997C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.KLMOOMBPHIO = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.OEOKBLIOGCB = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.DCNFJNLJEDO = input.ReadString();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						this.GBNOPNPEAOF = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.AMOIBMJGKNN = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.LLCMICAEFGM = input.ReadString();
						continue;
					}
					if (num == 58U)
					{
						this.MAC = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400165F RID: 5727
		private static readonly MessageParser<ExtraDeviceInfo> _parser = new MessageParser<ExtraDeviceInfo>(() => new ExtraDeviceInfo());

		// Token: 0x04001660 RID: 5728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001661 RID: 5729
		public const int KLMOOMBPHIOFieldNumber = 1;

		// Token: 0x04001662 RID: 5730
		private string kLMOOMBPHIO_ = "";

		// Token: 0x04001663 RID: 5731
		public const int OEOKBLIOGCBFieldNumber = 2;

		// Token: 0x04001664 RID: 5732
		private string oEOKBLIOGCB_ = "";

		// Token: 0x04001665 RID: 5733
		public const int DCNFJNLJEDOFieldNumber = 3;

		// Token: 0x04001666 RID: 5734
		private string dCNFJNLJEDO_ = "";

		// Token: 0x04001667 RID: 5735
		public const int GBNOPNPEAOFFieldNumber = 4;

		// Token: 0x04001668 RID: 5736
		private string gBNOPNPEAOF_ = "";

		// Token: 0x04001669 RID: 5737
		public const int AMOIBMJGKNNFieldNumber = 5;

		// Token: 0x0400166A RID: 5738
		private string aMOIBMJGKNN_ = "";

		// Token: 0x0400166B RID: 5739
		public const int LLCMICAEFGMFieldNumber = 6;

		// Token: 0x0400166C RID: 5740
		private string lLCMICAEFGM_ = "";

		// Token: 0x0400166D RID: 5741
		public const int MACFieldNumber = 7;

		// Token: 0x0400166E RID: 5742
		private string mAC_ = "";
	}
}
