using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200066D RID: 1645
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurAssistScRsp : IMessage<GetCurAssistScRsp>, IMessage, IEquatable<GetCurAssistScRsp>, IDeepCloneable<GetCurAssistScRsp>, IBufferMessage
	{
		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x000C8E93 File Offset: 0x000C7093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurAssistScRsp> Parser
		{
			get
			{
				return GetCurAssistScRsp._parser;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060049B7 RID: 18871 RVA: 0x000C8E9A File Offset: 0x000C709A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurAssistScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x000C8EAC File Offset: 0x000C70AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurAssistScRsp.Descriptor;
			}
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x000C8EB3 File Offset: 0x000C70B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistScRsp()
		{
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x000C8EBC File Offset: 0x000C70BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistScRsp(GetCurAssistScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.fRIENDAPPLYSOURCEASSIST_ = ((other.fRIENDAPPLYSOURCEASSIST_ != null) ? other.fRIENDAPPLYSOURCEASSIST_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x000C8F08 File Offset: 0x000C7108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurAssistScRsp Clone()
		{
			return new GetCurAssistScRsp(this);
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060049BC RID: 18876 RVA: 0x000C8F10 File Offset: 0x000C7110
		// (set) Token: 0x060049BD RID: 18877 RVA: 0x000C8F18 File Offset: 0x000C7118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x000C8F21 File Offset: 0x000C7121
		// (set) Token: 0x060049BF RID: 18879 RVA: 0x000C8F29 File Offset: 0x000C7129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAssistInfo FRIENDAPPLYSOURCEASSIST
		{
			get
			{
				return this.fRIENDAPPLYSOURCEASSIST_;
			}
			set
			{
				this.fRIENDAPPLYSOURCEASSIST_ = value;
			}
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x000C8F32 File Offset: 0x000C7132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurAssistScRsp);
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x000C8F40 File Offset: 0x000C7140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurAssistScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.FRIENDAPPLYSOURCEASSIST, other.FRIENDAPPLYSOURCEASSIST) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x000C8F90 File Offset: 0x000C7190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				num ^= this.FRIENDAPPLYSOURCEASSIST.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x000C8FE5 File Offset: 0x000C71E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x000C8FED File Offset: 0x000C71ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x000C8FF8 File Offset: 0x000C71F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FRIENDAPPLYSOURCEASSIST);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049C6 RID: 18886 RVA: 0x000C9050 File Offset: 0x000C7250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FRIENDAPPLYSOURCEASSIST);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x000C90A8 File Offset: 0x000C72A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurAssistScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				if (this.fRIENDAPPLYSOURCEASSIST_ == null)
				{
					this.FRIENDAPPLYSOURCEASSIST = new PlayerAssistInfo();
				}
				this.FRIENDAPPLYSOURCEASSIST.MergeFrom(other.FRIENDAPPLYSOURCEASSIST);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000C9110 File Offset: 0x000C7310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x000C911C File Offset: 0x000C731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.fRIENDAPPLYSOURCEASSIST_ == null)
						{
							this.FRIENDAPPLYSOURCEASSIST = new PlayerAssistInfo();
						}
						input.ReadMessage(this.FRIENDAPPLYSOURCEASSIST);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D54 RID: 7508
		private static readonly MessageParser<GetCurAssistScRsp> _parser = new MessageParser<GetCurAssistScRsp>(() => new GetCurAssistScRsp());

		// Token: 0x04001D55 RID: 7509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D56 RID: 7510
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001D57 RID: 7511
		private uint retcode_;

		// Token: 0x04001D58 RID: 7512
		public const int FRIENDAPPLYSOURCEASSISTFieldNumber = 15;

		// Token: 0x04001D59 RID: 7513
		private PlayerAssistInfo fRIENDAPPLYSOURCEASSIST_;
	}
}
