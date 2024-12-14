using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006D7 RID: 1751
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGachaCeilingScRsp : IMessage<GetGachaCeilingScRsp>, IMessage, IEquatable<GetGachaCeilingScRsp>, IDeepCloneable<GetGachaCeilingScRsp>, IBufferMessage
	{
		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x000D3F8F File Offset: 0x000D218F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGachaCeilingScRsp> Parser
		{
			get
			{
				return GetGachaCeilingScRsp._parser;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x000D3F96 File Offset: 0x000D2196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGachaCeilingScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004E58 RID: 20056 RVA: 0x000D3FA8 File Offset: 0x000D21A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGachaCeilingScRsp.Descriptor;
			}
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x000D3FAF File Offset: 0x000D21AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingScRsp()
		{
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x000D3FB8 File Offset: 0x000D21B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingScRsp(GetGachaCeilingScRsp other) : this()
		{
			this.gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
			this.gachaType_ = other.gachaType_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x000D4010 File Offset: 0x000D2210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGachaCeilingScRsp Clone()
		{
			return new GetGachaCeilingScRsp(this);
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x000D4018 File Offset: 0x000D2218
		// (set) Token: 0x06004E5D RID: 20061 RVA: 0x000D4020 File Offset: 0x000D2220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling GachaCeiling
		{
			get
			{
				return this.gachaCeiling_;
			}
			set
			{
				this.gachaCeiling_ = value;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06004E5E RID: 20062 RVA: 0x000D4029 File Offset: 0x000D2229
		// (set) Token: 0x06004E5F RID: 20063 RVA: 0x000D4031 File Offset: 0x000D2231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaType
		{
			get
			{
				return this.gachaType_;
			}
			set
			{
				this.gachaType_ = value;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004E60 RID: 20064 RVA: 0x000D403A File Offset: 0x000D223A
		// (set) Token: 0x06004E61 RID: 20065 RVA: 0x000D4042 File Offset: 0x000D2242
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

		// Token: 0x06004E62 RID: 20066 RVA: 0x000D404B File Offset: 0x000D224B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGachaCeilingScRsp);
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x000D405C File Offset: 0x000D225C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGachaCeilingScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GachaCeiling, other.GachaCeiling) && this.GachaType == other.GachaType && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x000D40BC File Offset: 0x000D22BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaCeiling_ != null)
			{
				num ^= this.GachaCeiling.GetHashCode();
			}
			if (this.GachaType != 0U)
			{
				num ^= this.GachaType.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x000D412A File Offset: 0x000D232A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x000D4132 File Offset: 0x000D2332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x000D413C File Offset: 0x000D233C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.gachaCeiling_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GachaCeiling);
			}
			if (this.GachaType != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x000D41B4 File Offset: 0x000D23B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaCeiling_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaCeiling);
			}
			if (this.GachaType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaType);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x000D4224 File Offset: 0x000D2424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGachaCeilingScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaCeiling_ != null)
			{
				if (this.gachaCeiling_ == null)
				{
					this.GachaCeiling = new GachaCeiling();
				}
				this.GachaCeiling.MergeFrom(other.GachaCeiling);
			}
			if (other.GachaType != 0U)
			{
				this.GachaType = other.GachaType;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x000D42A0 File Offset: 0x000D24A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x000D42AC File Offset: 0x000D24AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 74U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GachaType = input.ReadUInt32();
						}
					}
					else
					{
						if (this.gachaCeiling_ == null)
						{
							this.GachaCeiling = new GachaCeiling();
						}
						input.ReadMessage(this.GachaCeiling);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EEE RID: 7918
		private static readonly MessageParser<GetGachaCeilingScRsp> _parser = new MessageParser<GetGachaCeilingScRsp>(() => new GetGachaCeilingScRsp());

		// Token: 0x04001EEF RID: 7919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EF0 RID: 7920
		public const int GachaCeilingFieldNumber = 9;

		// Token: 0x04001EF1 RID: 7921
		private GachaCeiling gachaCeiling_;

		// Token: 0x04001EF2 RID: 7922
		public const int GachaTypeFieldNumber = 11;

		// Token: 0x04001EF3 RID: 7923
		private uint gachaType_;

		// Token: 0x04001EF4 RID: 7924
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001EF5 RID: 7925
		private uint retcode_;
	}
}
