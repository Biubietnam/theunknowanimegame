using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F23 RID: 3875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicStoryInfo : IMessage<RogueMagicStoryInfo>, IMessage, IEquatable<RogueMagicStoryInfo>, IDeepCloneable<RogueMagicStoryInfo>, IBufferMessage
	{
		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600ACE9 RID: 44265 RVA: 0x001D154C File Offset: 0x001CF74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicStoryInfo> Parser
		{
			get
			{
				return RogueMagicStoryInfo._parser;
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x001D1553 File Offset: 0x001CF753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicStoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600ACEB RID: 44267 RVA: 0x001D1565 File Offset: 0x001CF765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicStoryInfo.Descriptor;
			}
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x001D156C File Offset: 0x001CF76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfo()
		{
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x001D157F File Offset: 0x001CF77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfo(RogueMagicStoryInfo other) : this()
		{
			this.finishedMagicStoryList_ = other.finishedMagicStoryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x001D15A9 File Offset: 0x001CF7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStoryInfo Clone()
		{
			return new RogueMagicStoryInfo(this);
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600ACEF RID: 44271 RVA: 0x001D15B1 File Offset: 0x001CF7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedMagicStoryList
		{
			get
			{
				return this.finishedMagicStoryList_;
			}
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x001D15B9 File Offset: 0x001CF7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicStoryInfo);
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x001D15C7 File Offset: 0x001CF7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicStoryInfo other)
		{
			return other != null && (other == this || (this.finishedMagicStoryList_.Equals(other.finishedMagicStoryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x001D15FC File Offset: 0x001CF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.finishedMagicStoryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x001D1630 File Offset: 0x001CF830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x001D1638 File Offset: 0x001CF838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x001D1641 File Offset: 0x001CF841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finishedMagicStoryList_.WriteTo(ref output, RogueMagicStoryInfo._repeated_finishedMagicStoryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x001D1668 File Offset: 0x001CF868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.finishedMagicStoryList_.CalculateSize(RogueMagicStoryInfo._repeated_finishedMagicStoryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x001D16A1 File Offset: 0x001CF8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicStoryInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.finishedMagicStoryList_.Add(other.finishedMagicStoryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x001D16CF File Offset: 0x001CF8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x001D16D8 File Offset: 0x001CF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.finishedMagicStoryList_.AddEntriesFrom(ref input, RogueMagicStoryInfo._repeated_finishedMagicStoryList_codec);
				}
			}
		}

		// Token: 0x04004677 RID: 18039
		private static readonly MessageParser<RogueMagicStoryInfo> _parser = new MessageParser<RogueMagicStoryInfo>(() => new RogueMagicStoryInfo());

		// Token: 0x04004678 RID: 18040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004679 RID: 18041
		public const int FinishedMagicStoryListFieldNumber = 14;

		// Token: 0x0400467A RID: 18042
		private static readonly FieldCodec<uint> _repeated_finishedMagicStoryList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x0400467B RID: 18043
		private readonly RepeatedField<uint> finishedMagicStoryList_ = new RepeatedField<uint>();
	}
}
