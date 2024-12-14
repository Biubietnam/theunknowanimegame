using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200112B RID: 4395
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetRogueExhibitionCsReq : IMessage<SetRogueExhibitionCsReq>, IMessage, IEquatable<SetRogueExhibitionCsReq>, IDeepCloneable<SetRogueExhibitionCsReq>, IBufferMessage
	{
		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600C400 RID: 50176 RVA: 0x0020E25F File Offset: 0x0020C45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetRogueExhibitionCsReq> Parser
		{
			get
			{
				return SetRogueExhibitionCsReq._parser;
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600C401 RID: 50177 RVA: 0x0020E266 File Offset: 0x0020C466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetRogueExhibitionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600C402 RID: 50178 RVA: 0x0020E278 File Offset: 0x0020C478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetRogueExhibitionCsReq.Descriptor;
			}
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x0020E27F File Offset: 0x0020C47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionCsReq()
		{
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x0020E2A8 File Offset: 0x0020C4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionCsReq(SetRogueExhibitionCsReq other) : this()
		{
			this.iEOBDKKBHLF_ = other.iEOBDKKBHLF_.Clone();
			this.lAPIDEOBJGL_ = other.lAPIDEOBJGL_.Clone();
			this.nBJKMCJFIJC_ = other.nBJKMCJFIJC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x0020E2FF File Offset: 0x0020C4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetRogueExhibitionCsReq Clone()
		{
			return new SetRogueExhibitionCsReq(this);
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600C406 RID: 50182 RVA: 0x0020E307 File Offset: 0x0020C507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> IEOBDKKBHLF
		{
			get
			{
				return this.iEOBDKKBHLF_;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600C407 RID: 50183 RVA: 0x0020E30F File Offset: 0x0020C50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCollectionExhibitionOperateType> LAPIDEOBJGL
		{
			get
			{
				return this.lAPIDEOBJGL_;
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600C408 RID: 50184 RVA: 0x0020E317 File Offset: 0x0020C517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NBJKMCJFIJC
		{
			get
			{
				return this.nBJKMCJFIJC_;
			}
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x0020E31F File Offset: 0x0020C51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetRogueExhibitionCsReq);
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x0020E330 File Offset: 0x0020C530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetRogueExhibitionCsReq other)
		{
			return other != null && (other == this || (this.iEOBDKKBHLF_.Equals(other.iEOBDKKBHLF_) && this.lAPIDEOBJGL_.Equals(other.lAPIDEOBJGL_) && this.nBJKMCJFIJC_.Equals(other.nBJKMCJFIJC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x0020E398 File Offset: 0x0020C598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iEOBDKKBHLF_.GetHashCode();
			num ^= this.lAPIDEOBJGL_.GetHashCode();
			num ^= this.nBJKMCJFIJC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C40C RID: 50188 RVA: 0x0020E3E8 File Offset: 0x0020C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x0020E3F0 File Offset: 0x0020C5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C40E RID: 50190 RVA: 0x0020E3FC File Offset: 0x0020C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lAPIDEOBJGL_.WriteTo(ref output, SetRogueExhibitionCsReq._repeated_lAPIDEOBJGL_codec);
			this.iEOBDKKBHLF_.WriteTo(ref output, SetRogueExhibitionCsReq._repeated_iEOBDKKBHLF_codec);
			this.nBJKMCJFIJC_.WriteTo(ref output, SetRogueExhibitionCsReq._repeated_nBJKMCJFIJC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x0020E450 File Offset: 0x0020C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iEOBDKKBHLF_.CalculateSize(SetRogueExhibitionCsReq._repeated_iEOBDKKBHLF_codec);
			num += this.lAPIDEOBJGL_.CalculateSize(SetRogueExhibitionCsReq._repeated_lAPIDEOBJGL_codec);
			num += this.nBJKMCJFIJC_.CalculateSize(SetRogueExhibitionCsReq._repeated_nBJKMCJFIJC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x0020E4B0 File Offset: 0x0020C6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetRogueExhibitionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.iEOBDKKBHLF_.Add(other.iEOBDKKBHLF_);
			this.lAPIDEOBJGL_.Add(other.lAPIDEOBJGL_);
			this.nBJKMCJFIJC_.Add(other.nBJKMCJFIJC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x0020E50B File Offset: 0x0020C70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x0020E514 File Offset: 0x0020C714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U || num == 34U)
					{
						this.lAPIDEOBJGL_.AddEntriesFrom(ref input, SetRogueExhibitionCsReq._repeated_lAPIDEOBJGL_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_4E;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_4E;
					}
					if (num == 64U || num == 66U)
					{
						this.nBJKMCJFIJC_.AddEntriesFrom(ref input, SetRogueExhibitionCsReq._repeated_nBJKMCJFIJC_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4E:
				this.iEOBDKKBHLF_.AddEntriesFrom(ref input, SetRogueExhibitionCsReq._repeated_iEOBDKKBHLF_codec);
			}
		}

		// Token: 0x04004F35 RID: 20277
		private static readonly MessageParser<SetRogueExhibitionCsReq> _parser = new MessageParser<SetRogueExhibitionCsReq>(() => new SetRogueExhibitionCsReq());

		// Token: 0x04004F36 RID: 20278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F37 RID: 20279
		public const int IEOBDKKBHLFFieldNumber = 5;

		// Token: 0x04004F38 RID: 20280
		private static readonly FieldCodec<uint> _repeated_iEOBDKKBHLF_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04004F39 RID: 20281
		private readonly RepeatedField<uint> iEOBDKKBHLF_ = new RepeatedField<uint>();

		// Token: 0x04004F3A RID: 20282
		public const int LAPIDEOBJGLFieldNumber = 4;

		// Token: 0x04004F3B RID: 20283
		private static readonly FieldCodec<RogueCollectionExhibitionOperateType> _repeated_lAPIDEOBJGL_codec = FieldCodec.ForEnum<RogueCollectionExhibitionOperateType>(34U, (RogueCollectionExhibitionOperateType x) => (int)x, (int x) => (RogueCollectionExhibitionOperateType)x);

		// Token: 0x04004F3C RID: 20284
		private readonly RepeatedField<RogueCollectionExhibitionOperateType> lAPIDEOBJGL_ = new RepeatedField<RogueCollectionExhibitionOperateType>();

		// Token: 0x04004F3D RID: 20285
		public const int NBJKMCJFIJCFieldNumber = 8;

		// Token: 0x04004F3E RID: 20286
		private static readonly FieldCodec<uint> _repeated_nBJKMCJFIJC_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04004F3F RID: 20287
		private readonly RepeatedField<uint> nBJKMCJFIJC_ = new RepeatedField<uint>();
	}
}
