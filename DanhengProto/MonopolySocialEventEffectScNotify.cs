using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B7B RID: 2939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolySocialEventEffectScNotify : IMessage<MonopolySocialEventEffectScNotify>, IMessage, IEquatable<MonopolySocialEventEffectScNotify>, IDeepCloneable<MonopolySocialEventEffectScNotify>, IBufferMessage
	{
		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x06008214 RID: 33300 RVA: 0x00156AFF File Offset: 0x00154CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolySocialEventEffectScNotify> Parser
		{
			get
			{
				return MonopolySocialEventEffectScNotify._parser;
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x00156B06 File Offset: 0x00154D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolySocialEventEffectScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x00156B18 File Offset: 0x00154D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolySocialEventEffectScNotify.Descriptor;
			}
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x00156B1F File Offset: 0x00154D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySocialEventEffectScNotify()
		{
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00156B32 File Offset: 0x00154D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySocialEventEffectScNotify(MonopolySocialEventEffectScNotify other) : this()
		{
			this.pPFLDEOKIFI_ = other.pPFLDEOKIFI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00156B5C File Offset: 0x00154D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySocialEventEffectScNotify Clone()
		{
			return new MonopolySocialEventEffectScNotify(this);
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600821A RID: 33306 RVA: 0x00156B64 File Offset: 0x00154D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialEventServerCache> PPFLDEOKIFI
		{
			get
			{
				return this.pPFLDEOKIFI_;
			}
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00156B6C File Offset: 0x00154D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolySocialEventEffectScNotify);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x00156B7A File Offset: 0x00154D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolySocialEventEffectScNotify other)
		{
			return other != null && (other == this || (this.pPFLDEOKIFI_.Equals(other.pPFLDEOKIFI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x00156BB0 File Offset: 0x00154DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pPFLDEOKIFI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x00156BE4 File Offset: 0x00154DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x00156BEC File Offset: 0x00154DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x00156BF5 File Offset: 0x00154DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pPFLDEOKIFI_.WriteTo(ref output, MonopolySocialEventEffectScNotify._repeated_pPFLDEOKIFI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x00156C1C File Offset: 0x00154E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pPFLDEOKIFI_.CalculateSize(MonopolySocialEventEffectScNotify._repeated_pPFLDEOKIFI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x00156C55 File Offset: 0x00154E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolySocialEventEffectScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pPFLDEOKIFI_.Add(other.pPFLDEOKIFI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x00156C83 File Offset: 0x00154E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x00156C8C File Offset: 0x00154E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pPFLDEOKIFI_.AddEntriesFrom(ref input, MonopolySocialEventEffectScNotify._repeated_pPFLDEOKIFI_codec);
				}
			}
		}

		// Token: 0x0400319F RID: 12703
		private static readonly MessageParser<MonopolySocialEventEffectScNotify> _parser = new MessageParser<MonopolySocialEventEffectScNotify>(() => new MonopolySocialEventEffectScNotify());

		// Token: 0x040031A0 RID: 12704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031A1 RID: 12705
		public const int PPFLDEOKIFIFieldNumber = 10;

		// Token: 0x040031A2 RID: 12706
		private static readonly FieldCodec<SocialEventServerCache> _repeated_pPFLDEOKIFI_codec = FieldCodec.ForMessage<SocialEventServerCache>(82U, SocialEventServerCache.Parser);

		// Token: 0x040031A3 RID: 12707
		private readonly RepeatedField<SocialEventServerCache> pPFLDEOKIFI_ = new RepeatedField<SocialEventServerCache>();
	}
}
