using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C0D RID: 3085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NewMailScNotify : IMessage<NewMailScNotify>, IMessage, IEquatable<NewMailScNotify>, IDeepCloneable<NewMailScNotify>, IBufferMessage
	{
		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06008890 RID: 34960 RVA: 0x00168678 File Offset: 0x00166878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewMailScNotify> Parser
		{
			get
			{
				return NewMailScNotify._parser;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06008891 RID: 34961 RVA: 0x0016867F File Offset: 0x0016687F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NewMailScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06008892 RID: 34962 RVA: 0x00168691 File Offset: 0x00166891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewMailScNotify.Descriptor;
			}
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x00168698 File Offset: 0x00166898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewMailScNotify()
		{
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x001686AB File Offset: 0x001668AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewMailScNotify(NewMailScNotify other) : this()
		{
			this.mailIdList_ = other.mailIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x001686D5 File Offset: 0x001668D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewMailScNotify Clone()
		{
			return new NewMailScNotify(this);
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06008896 RID: 34966 RVA: 0x001686DD File Offset: 0x001668DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MailIdList
		{
			get
			{
				return this.mailIdList_;
			}
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x001686E5 File Offset: 0x001668E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewMailScNotify);
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x001686F3 File Offset: 0x001668F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewMailScNotify other)
		{
			return other != null && (other == this || (this.mailIdList_.Equals(other.mailIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x00168728 File Offset: 0x00166928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mailIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x0016875C File Offset: 0x0016695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x00168764 File Offset: 0x00166964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x0016876D File Offset: 0x0016696D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mailIdList_.WriteTo(ref output, NewMailScNotify._repeated_mailIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x00168794 File Offset: 0x00166994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mailIdList_.CalculateSize(NewMailScNotify._repeated_mailIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x001687CD File Offset: 0x001669CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewMailScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mailIdList_.Add(other.mailIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x001687FB File Offset: 0x001669FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088A0 RID: 34976 RVA: 0x00168804 File Offset: 0x00166A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mailIdList_.AddEntriesFrom(ref input, NewMailScNotify._repeated_mailIdList_codec);
				}
			}
		}

		// Token: 0x04003456 RID: 13398
		private static readonly MessageParser<NewMailScNotify> _parser = new MessageParser<NewMailScNotify>(() => new NewMailScNotify());

		// Token: 0x04003457 RID: 13399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003458 RID: 13400
		public const int MailIdListFieldNumber = 13;

		// Token: 0x04003459 RID: 13401
		private static readonly FieldCodec<uint> _repeated_mailIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x0400345A RID: 13402
		private readonly RepeatedField<uint> mailIdList_ = new RepeatedField<uint>();
	}
}
