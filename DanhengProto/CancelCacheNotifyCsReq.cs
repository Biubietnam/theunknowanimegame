using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200015F RID: 351
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelCacheNotifyCsReq : IMessage<CancelCacheNotifyCsReq>, IMessage, IEquatable<CancelCacheNotifyCsReq>, IDeepCloneable<CancelCacheNotifyCsReq>, IBufferMessage
	{
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x0002DE2F File Offset: 0x0002C02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelCacheNotifyCsReq> Parser
		{
			get
			{
				return CancelCacheNotifyCsReq._parser;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0002DE36 File Offset: 0x0002C036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelCacheNotifyCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0002DE48 File Offset: 0x0002C048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelCacheNotifyCsReq.Descriptor;
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0002DE4F File Offset: 0x0002C04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyCsReq()
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0002DE70 File Offset: 0x0002C070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyCsReq(CancelCacheNotifyCsReq other) : this()
		{
			this.gGEPGHPENFG_ = other.gGEPGHPENFG_.Clone();
			this.hJHCCJGMPBC_ = other.hJHCCJGMPBC_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0002DEC2 File Offset: 0x0002C0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelCacheNotifyCsReq Clone()
		{
			return new CancelCacheNotifyCsReq(this);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0002DECA File Offset: 0x0002C0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GGEPGHPENFG
		{
			get
			{
				return this.gGEPGHPENFG_;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0002DED2 File Offset: 0x0002C0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HJHCCJGMPBC
		{
			get
			{
				return this.hJHCCJGMPBC_;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0002DEDA File Offset: 0x0002C0DA
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0002DEE2 File Offset: 0x0002C0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ACNLEMFFGLJ Type
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

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0002DEEB File Offset: 0x0002C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelCacheNotifyCsReq);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelCacheNotifyCsReq other)
		{
			return other != null && (other == this || (this.gGEPGHPENFG_.Equals(other.gGEPGHPENFG_) && this.hJHCCJGMPBC_.Equals(other.hJHCCJGMPBC_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0002DF60 File Offset: 0x0002C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gGEPGHPENFG_.GetHashCode();
			num ^= this.hJHCCJGMPBC_.GetHashCode();
			if (this.Type != ACNLEMFFGLJ.CacheNotifyTypeNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0002DFC1 File Offset: 0x0002C1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0002DFC9 File Offset: 0x0002C1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gGEPGHPENFG_.WriteTo(ref output, CancelCacheNotifyCsReq._repeated_gGEPGHPENFG_codec);
			if (this.Type != ACNLEMFFGLJ.CacheNotifyTypeNone)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Type);
			}
			this.hJHCCJGMPBC_.WriteTo(ref output, CancelCacheNotifyCsReq._repeated_hJHCCJGMPBC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0002E034 File Offset: 0x0002C234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gGEPGHPENFG_.CalculateSize(CancelCacheNotifyCsReq._repeated_gGEPGHPENFG_codec);
			num += this.hJHCCJGMPBC_.CalculateSize(CancelCacheNotifyCsReq._repeated_hJHCCJGMPBC_codec);
			if (this.Type != ACNLEMFFGLJ.CacheNotifyTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0002E098 File Offset: 0x0002C298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelCacheNotifyCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.gGEPGHPENFG_.Add(other.gGEPGHPENFG_);
			this.hJHCCJGMPBC_.Add(other.hJHCCJGMPBC_);
			if (other.Type != ACNLEMFFGLJ.CacheNotifyTypeNone)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0002E0F6 File Offset: 0x0002C2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0002E100 File Offset: 0x0002C300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.gGEPGHPENFG_.AddEntriesFrom(ref input, CancelCacheNotifyCsReq._repeated_gGEPGHPENFG_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Type = (ACNLEMFFGLJ)input.ReadEnum();
						continue;
					}
					if (num == 74U)
					{
						this.hJHCCJGMPBC_.AddEntriesFrom(ref input, CancelCacheNotifyCsReq._repeated_hJHCCJGMPBC_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040006AD RID: 1709
		private static readonly MessageParser<CancelCacheNotifyCsReq> _parser = new MessageParser<CancelCacheNotifyCsReq>(() => new CancelCacheNotifyCsReq());

		// Token: 0x040006AE RID: 1710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006AF RID: 1711
		public const int GGEPGHPENFGFieldNumber = 4;

		// Token: 0x040006B0 RID: 1712
		private static readonly FieldCodec<uint> _repeated_gGEPGHPENFG_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040006B1 RID: 1713
		private readonly RepeatedField<uint> gGEPGHPENFG_ = new RepeatedField<uint>();

		// Token: 0x040006B2 RID: 1714
		public const int HJHCCJGMPBCFieldNumber = 9;

		// Token: 0x040006B3 RID: 1715
		private static readonly FieldCodec<string> _repeated_hJHCCJGMPBC_codec = FieldCodec.ForString(74U);

		// Token: 0x040006B4 RID: 1716
		private readonly RepeatedField<string> hJHCCJGMPBC_ = new RepeatedField<string>();

		// Token: 0x040006B5 RID: 1717
		public const int TypeFieldNumber = 7;

		// Token: 0x040006B6 RID: 1718
		private ACNLEMFFGLJ type_;
	}
}
