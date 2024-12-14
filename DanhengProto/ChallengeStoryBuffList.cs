using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001BF RID: 447
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeStoryBuffList : IMessage<ChallengeStoryBuffList>, IMessage, IEquatable<ChallengeStoryBuffList>, IDeepCloneable<ChallengeStoryBuffList>, IBufferMessage
	{
		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00039CB0 File Offset: 0x00037EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeStoryBuffList> Parser
		{
			get
			{
				return ChallengeStoryBuffList._parser;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00039CB7 File Offset: 0x00037EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryBuffListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x00039CC9 File Offset: 0x00037EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeStoryBuffList.Descriptor;
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00039CD0 File Offset: 0x00037ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffList()
		{
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00039CE3 File Offset: 0x00037EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffList(ChallengeStoryBuffList other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00039D0D File Offset: 0x00037F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeStoryBuffList Clone()
		{
			return new ChallengeStoryBuffList(this);
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00039D15 File Offset: 0x00037F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00039D1D File Offset: 0x00037F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeStoryBuffList);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00039D2B File Offset: 0x00037F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeStoryBuffList other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00039D60 File Offset: 0x00037F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00039D94 File Offset: 0x00037F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00039D9C File Offset: 0x00037F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00039DA5 File Offset: 0x00037FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, ChallengeStoryBuffList._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00039DCC File Offset: 0x00037FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(ChallengeStoryBuffList._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00039E05 File Offset: 0x00038005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeStoryBuffList other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00039E33 File Offset: 0x00038033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00039E3C File Offset: 0x0003803C
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
					this.buffList_.AddEntriesFrom(ref input, ChallengeStoryBuffList._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x04000872 RID: 2162
		private static readonly MessageParser<ChallengeStoryBuffList> _parser = new MessageParser<ChallengeStoryBuffList>(() => new ChallengeStoryBuffList());

		// Token: 0x04000873 RID: 2163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000874 RID: 2164
		public const int BuffListFieldNumber = 9;

		// Token: 0x04000875 RID: 2165
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04000876 RID: 2166
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();
	}
}
