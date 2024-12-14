using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C15 RID: 3093
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NGHOLIKIEPB : IMessage<NGHOLIKIEPB>, IMessage, IEquatable<NGHOLIKIEPB>, IDeepCloneable<NGHOLIKIEPB>, IBufferMessage
	{
		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x060088F1 RID: 35057 RVA: 0x001697FB File Offset: 0x001679FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NGHOLIKIEPB> Parser
		{
			get
			{
				return NGHOLIKIEPB._parser;
			}
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00169802 File Offset: 0x00167A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NGHOLIKIEPBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x060088F3 RID: 35059 RVA: 0x00169814 File Offset: 0x00167A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NGHOLIKIEPB.Descriptor;
			}
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x0016981B File Offset: 0x00167A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGHOLIKIEPB()
		{
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x00169823 File Offset: 0x00167A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGHOLIKIEPB(NGHOLIKIEPB other) : this()
		{
			this.type_ = other.type_;
			this.gHNIMKKGDBO_ = other.gHNIMKKGDBO_;
			this.displayValue_ = other.displayValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x00169860 File Offset: 0x00167A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGHOLIKIEPB Clone()
		{
			return new NGHOLIKIEPB(this);
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x00169868 File Offset: 0x00167A68
		// (set) Token: 0x060088F8 RID: 35064 RVA: 0x00169870 File Offset: 0x00167A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleStaticticEventType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x060088F9 RID: 35065 RVA: 0x00169879 File Offset: 0x00167A79
		// (set) Token: 0x060088FA RID: 35066 RVA: 0x00169881 File Offset: 0x00167A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHNIMKKGDBO
		{
			get
			{
				return this.gHNIMKKGDBO_;
			}
			set
			{
				this.gHNIMKKGDBO_ = value;
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x060088FB RID: 35067 RVA: 0x0016988A File Offset: 0x00167A8A
		// (set) Token: 0x060088FC RID: 35068 RVA: 0x00169892 File Offset: 0x00167A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DisplayValue
		{
			get
			{
				return this.displayValue_;
			}
			set
			{
				this.displayValue_ = value;
			}
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x0016989B File Offset: 0x00167A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NGHOLIKIEPB);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x001698AC File Offset: 0x00167AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NGHOLIKIEPB other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.GHNIMKKGDBO == other.GHNIMKKGDBO && this.DisplayValue == other.DisplayValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x00169908 File Offset: 0x00167B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BattleStaticticEventType.BattleStaticticEventNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.GHNIMKKGDBO != 0U)
			{
				num ^= this.GHNIMKKGDBO.GetHashCode();
			}
			if (this.DisplayValue != 0U)
			{
				num ^= this.DisplayValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x0016997F File Offset: 0x00167B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x00169987 File Offset: 0x00167B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x00169990 File Offset: 0x00167B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != BattleStaticticEventType.BattleStaticticEventNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.GHNIMKKGDBO != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GHNIMKKGDBO);
			}
			if (this.DisplayValue != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.DisplayValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x00169A04 File Offset: 0x00167C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BattleStaticticEventType.BattleStaticticEventNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.GHNIMKKGDBO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHNIMKKGDBO);
			}
			if (this.DisplayValue != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DisplayValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x00169A74 File Offset: 0x00167C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NGHOLIKIEPB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BattleStaticticEventType.BattleStaticticEventNone)
			{
				this.Type = other.Type;
			}
			if (other.GHNIMKKGDBO != 0U)
			{
				this.GHNIMKKGDBO = other.GHNIMKKGDBO;
			}
			if (other.DisplayValue != 0U)
			{
				this.DisplayValue = other.DisplayValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008905 RID: 35077 RVA: 0x00169AD8 File Offset: 0x00167CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x00169AE4 File Offset: 0x00167CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DisplayValue = input.ReadUInt32();
						}
					}
					else
					{
						this.GHNIMKKGDBO = input.ReadUInt32();
					}
				}
				else
				{
					this.Type = (BattleStaticticEventType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003479 RID: 13433
		private static readonly MessageParser<NGHOLIKIEPB> _parser = new MessageParser<NGHOLIKIEPB>(() => new NGHOLIKIEPB());

		// Token: 0x0400347A RID: 13434
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400347B RID: 13435
		public const int TypeFieldNumber = 1;

		// Token: 0x0400347C RID: 13436
		private BattleStaticticEventType type_;

		// Token: 0x0400347D RID: 13437
		public const int GHNIMKKGDBOFieldNumber = 2;

		// Token: 0x0400347E RID: 13438
		private uint gHNIMKKGDBO_;

		// Token: 0x0400347F RID: 13439
		public const int DisplayValueFieldNumber = 3;

		// Token: 0x04003480 RID: 13440
		private uint displayValue_;
	}
}
