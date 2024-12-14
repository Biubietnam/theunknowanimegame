using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001329 RID: 4905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEventHandbookRewardCsReq : IMessage<TakeRogueEventHandbookRewardCsReq>, IMessage, IEquatable<TakeRogueEventHandbookRewardCsReq>, IDeepCloneable<TakeRogueEventHandbookRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x002470FD File Offset: 0x002452FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEventHandbookRewardCsReq> Parser
		{
			get
			{
				return TakeRogueEventHandbookRewardCsReq._parser;
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600DAE3 RID: 56035 RVA: 0x00247104 File Offset: 0x00245304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEventHandbookRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x00247116 File Offset: 0x00245316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEventHandbookRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x0024711D File Offset: 0x0024531D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardCsReq()
		{
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00247130 File Offset: 0x00245330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardCsReq(TakeRogueEventHandbookRewardCsReq other) : this()
		{
			this.handbookBuffList_ = other.handbookBuffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x0024715A File Offset: 0x0024535A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEventHandbookRewardCsReq Clone()
		{
			return new TakeRogueEventHandbookRewardCsReq(this);
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600DAE8 RID: 56040 RVA: 0x00247162 File Offset: 0x00245362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HandbookBuffList
		{
			get
			{
				return this.handbookBuffList_;
			}
		}

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x0024716A File Offset: 0x0024536A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEventHandbookRewardCsReq);
		}

		// Token: 0x0600DAEA RID: 56042 RVA: 0x00247178 File Offset: 0x00245378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEventHandbookRewardCsReq other)
		{
			return other != null && (other == this || (this.handbookBuffList_.Equals(other.handbookBuffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAEB RID: 56043 RVA: 0x002471AC File Offset: 0x002453AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.handbookBuffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAEC RID: 56044 RVA: 0x002471E0 File Offset: 0x002453E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DAED RID: 56045 RVA: 0x002471E8 File Offset: 0x002453E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x002471F1 File Offset: 0x002453F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.handbookBuffList_.WriteTo(ref output, TakeRogueEventHandbookRewardCsReq._repeated_handbookBuffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00247218 File Offset: 0x00245418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.handbookBuffList_.CalculateSize(TakeRogueEventHandbookRewardCsReq._repeated_handbookBuffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00247251 File Offset: 0x00245451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEventHandbookRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.handbookBuffList_.Add(other.handbookBuffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DAF1 RID: 56049 RVA: 0x0024727F File Offset: 0x0024547F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAF2 RID: 56050 RVA: 0x00247288 File Offset: 0x00245488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.handbookBuffList_.AddEntriesFrom(ref input, TakeRogueEventHandbookRewardCsReq._repeated_handbookBuffList_codec);
				}
			}
		}

		// Token: 0x0400572A RID: 22314
		private static readonly MessageParser<TakeRogueEventHandbookRewardCsReq> _parser = new MessageParser<TakeRogueEventHandbookRewardCsReq>(() => new TakeRogueEventHandbookRewardCsReq());

		// Token: 0x0400572B RID: 22315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400572C RID: 22316
		public const int HandbookBuffListFieldNumber = 9;

		// Token: 0x0400572D RID: 22317
		private static readonly FieldCodec<uint> _repeated_handbookBuffList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x0400572E RID: 22318
		private readonly RepeatedField<uint> handbookBuffList_ = new RepeatedField<uint>();
	}
}
