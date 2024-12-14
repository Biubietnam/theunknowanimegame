using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007DB RID: 2011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRollShopInfoScRsp : IMessage<GetRollShopInfoScRsp>, IMessage, IEquatable<GetRollShopInfoScRsp>, IDeepCloneable<GetRollShopInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x000EF383 File Offset: 0x000ED583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRollShopInfoScRsp> Parser
		{
			get
			{
				return GetRollShopInfoScRsp._parser;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x000EF38A File Offset: 0x000ED58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRollShopInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x000EF39C File Offset: 0x000ED59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRollShopInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x000EF3A3 File Offset: 0x000ED5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoScRsp()
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x000EF3B8 File Offset: 0x000ED5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoScRsp(GetRollShopInfoScRsp other) : this()
		{
			this.gachaRandom_ = other.gachaRandom_;
			this.shopGroupIdList_ = other.shopGroupIdList_.Clone();
			this.retcode_ = other.retcode_;
			this.rollShopId_ = other.rollShopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x000EF411 File Offset: 0x000ED611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoScRsp Clone()
		{
			return new GetRollShopInfoScRsp(this);
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x000EF419 File Offset: 0x000ED619
		// (set) Token: 0x060059B5 RID: 22965 RVA: 0x000EF421 File Offset: 0x000ED621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x000EF42A File Offset: 0x000ED62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ShopGroupIdList
		{
			get
			{
				return this.shopGroupIdList_;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x000EF432 File Offset: 0x000ED632
		// (set) Token: 0x060059B8 RID: 22968 RVA: 0x000EF43A File Offset: 0x000ED63A
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

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060059B9 RID: 22969 RVA: 0x000EF443 File Offset: 0x000ED643
		// (set) Token: 0x060059BA RID: 22970 RVA: 0x000EF44B File Offset: 0x000ED64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x000EF454 File Offset: 0x000ED654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRollShopInfoScRsp);
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x000EF464 File Offset: 0x000ED664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRollShopInfoScRsp other)
		{
			return other != null && (other == this || (this.GachaRandom == other.GachaRandom && this.shopGroupIdList_.Equals(other.shopGroupIdList_) && this.Retcode == other.Retcode && this.RollShopId == other.RollShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x000EF4D4 File Offset: 0x000ED6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			num ^= this.shopGroupIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x000EF553 File Offset: 0x000ED753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x000EF55B File Offset: 0x000ED75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x000EF564 File Offset: 0x000ED764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.RollShopId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.shopGroupIdList_.WriteTo(ref output, GetRollShopInfoScRsp._repeated_shopGroupIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x000EF5EC File Offset: 0x000ED7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			num += this.shopGroupIdList_.CalculateSize(GetRollShopInfoScRsp._repeated_shopGroupIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x000EF670 File Offset: 0x000ED870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRollShopInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			this.shopGroupIdList_.Add(other.shopGroupIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x000EF6E5 File Offset: 0x000ED8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x000EF6F0 File Offset: 0x000ED8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.GachaRandom = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RollShopId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.shopGroupIdList_.AddEntriesFrom(ref input, GetRollShopInfoScRsp._repeated_shopGroupIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022D2 RID: 8914
		private static readonly MessageParser<GetRollShopInfoScRsp> _parser = new MessageParser<GetRollShopInfoScRsp>(() => new GetRollShopInfoScRsp());

		// Token: 0x040022D3 RID: 8915
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D4 RID: 8916
		public const int GachaRandomFieldNumber = 4;

		// Token: 0x040022D5 RID: 8917
		private uint gachaRandom_;

		// Token: 0x040022D6 RID: 8918
		public const int ShopGroupIdListFieldNumber = 14;

		// Token: 0x040022D7 RID: 8919
		private static readonly FieldCodec<uint> _repeated_shopGroupIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040022D8 RID: 8920
		private readonly RepeatedField<uint> shopGroupIdList_ = new RepeatedField<uint>();

		// Token: 0x040022D9 RID: 8921
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040022DA RID: 8922
		private uint retcode_;

		// Token: 0x040022DB RID: 8923
		public const int RollShopIdFieldNumber = 9;

		// Token: 0x040022DC RID: 8924
		private uint rollShopId_;
	}
}
