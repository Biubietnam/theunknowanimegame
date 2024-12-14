using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200134F RID: 4943
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinBatchSaveCsReq : IMessage<TextJoinBatchSaveCsReq>, IMessage, IEquatable<TextJoinBatchSaveCsReq>, IDeepCloneable<TextJoinBatchSaveCsReq>, IBufferMessage
	{
		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600DC9C RID: 56476 RVA: 0x0024B679 File Offset: 0x00249879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinBatchSaveCsReq> Parser
		{
			get
			{
				return TextJoinBatchSaveCsReq._parser;
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600DC9D RID: 56477 RVA: 0x0024B680 File Offset: 0x00249880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinBatchSaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x0024B692 File Offset: 0x00249892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinBatchSaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x0024B699 File Offset: 0x00249899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveCsReq()
		{
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x0024B6AC File Offset: 0x002498AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveCsReq(TextJoinBatchSaveCsReq other) : this()
		{
			this.textJoinList_ = other.textJoinList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x0024B6D6 File Offset: 0x002498D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinBatchSaveCsReq Clone()
		{
			return new TextJoinBatchSaveCsReq(this);
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x0024B6DE File Offset: 0x002498DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TextJoinInfo> TextJoinList
		{
			get
			{
				return this.textJoinList_;
			}
		}

		// Token: 0x0600DCA3 RID: 56483 RVA: 0x0024B6E6 File Offset: 0x002498E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinBatchSaveCsReq);
		}

		// Token: 0x0600DCA4 RID: 56484 RVA: 0x0024B6F4 File Offset: 0x002498F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinBatchSaveCsReq other)
		{
			return other != null && (other == this || (this.textJoinList_.Equals(other.textJoinList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x0024B728 File Offset: 0x00249928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.textJoinList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x0024B75C File Offset: 0x0024995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DCA7 RID: 56487 RVA: 0x0024B764 File Offset: 0x00249964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCA8 RID: 56488 RVA: 0x0024B76D File Offset: 0x0024996D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.textJoinList_.WriteTo(ref output, TextJoinBatchSaveCsReq._repeated_textJoinList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCA9 RID: 56489 RVA: 0x0024B794 File Offset: 0x00249994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.textJoinList_.CalculateSize(TextJoinBatchSaveCsReq._repeated_textJoinList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCAA RID: 56490 RVA: 0x0024B7CD File Offset: 0x002499CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinBatchSaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.textJoinList_.Add(other.textJoinList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCAB RID: 56491 RVA: 0x0024B7FB File Offset: 0x002499FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCAC RID: 56492 RVA: 0x0024B804 File Offset: 0x00249A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.textJoinList_.AddEntriesFrom(ref input, TextJoinBatchSaveCsReq._repeated_textJoinList_codec);
				}
			}
		}

		// Token: 0x040057C2 RID: 22466
		private static readonly MessageParser<TextJoinBatchSaveCsReq> _parser = new MessageParser<TextJoinBatchSaveCsReq>(() => new TextJoinBatchSaveCsReq());

		// Token: 0x040057C3 RID: 22467
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057C4 RID: 22468
		public const int TextJoinListFieldNumber = 14;

		// Token: 0x040057C5 RID: 22469
		private static readonly FieldCodec<TextJoinInfo> _repeated_textJoinList_codec = FieldCodec.ForMessage<TextJoinInfo>(114U, TextJoinInfo.Parser);

		// Token: 0x040057C6 RID: 22470
		private readonly RepeatedField<TextJoinInfo> textJoinList_ = new RepeatedField<TextJoinInfo>();
	}
}
