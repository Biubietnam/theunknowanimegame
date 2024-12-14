using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012CF RID: 4815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeCityShopRewardCsReq : IMessage<TakeCityShopRewardCsReq>, IMessage, IEquatable<TakeCityShopRewardCsReq>, IDeepCloneable<TakeCityShopRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x0023CD30 File Offset: 0x0023AF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeCityShopRewardCsReq> Parser
		{
			get
			{
				return TakeCityShopRewardCsReq._parser;
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x0023CD37 File Offset: 0x0023AF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeCityShopRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600D6C9 RID: 54985 RVA: 0x0023CD49 File Offset: 0x0023AF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeCityShopRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x0023CD50 File Offset: 0x0023AF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardCsReq()
		{
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x0023CD58 File Offset: 0x0023AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardCsReq(TakeCityShopRewardCsReq other) : this()
		{
			this.shopId_ = other.shopId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x0023CD89 File Offset: 0x0023AF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeCityShopRewardCsReq Clone()
		{
			return new TakeCityShopRewardCsReq(this);
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600D6CD RID: 54989 RVA: 0x0023CD91 File Offset: 0x0023AF91
		// (set) Token: 0x0600D6CE RID: 54990 RVA: 0x0023CD99 File Offset: 0x0023AF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600D6CF RID: 54991 RVA: 0x0023CDA2 File Offset: 0x0023AFA2
		// (set) Token: 0x0600D6D0 RID: 54992 RVA: 0x0023CDAA File Offset: 0x0023AFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x0023CDB3 File Offset: 0x0023AFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeCityShopRewardCsReq);
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x0023CDC1 File Offset: 0x0023AFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeCityShopRewardCsReq other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x0023CE00 File Offset: 0x0023B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0U)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x0023CE58 File Offset: 0x0023B058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x0023CE60 File Offset: 0x0023B060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x0023CE6C File Offset: 0x0023B06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			if (this.ShopId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x0023CEC8 File Offset: 0x0023B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShopId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x0023CF20 File Offset: 0x0023B120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeCityShopRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0U)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x0023CF70 File Offset: 0x0023B170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x0023CF7C File Offset: 0x0023B17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShopId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055BF RID: 21951
		private static readonly MessageParser<TakeCityShopRewardCsReq> _parser = new MessageParser<TakeCityShopRewardCsReq>(() => new TakeCityShopRewardCsReq());

		// Token: 0x040055C0 RID: 21952
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C1 RID: 21953
		public const int ShopIdFieldNumber = 15;

		// Token: 0x040055C2 RID: 21954
		private uint shopId_;

		// Token: 0x040055C3 RID: 21955
		public const int LevelFieldNumber = 10;

		// Token: 0x040055C4 RID: 21956
		private uint level_;
	}
}
