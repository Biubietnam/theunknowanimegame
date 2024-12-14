using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A9 RID: 425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeLineupList : IMessage<ChallengeLineupList>, IMessage, IEquatable<ChallengeLineupList>, IDeepCloneable<ChallengeLineupList>, IBufferMessage
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x00037535 File Offset: 0x00035735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeLineupList> Parser
		{
			get
			{
				return ChallengeLineupList._parser;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0003753C File Offset: 0x0003573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeLineupListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0003754E File Offset: 0x0003574E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeLineupList.Descriptor;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00037555 File Offset: 0x00035755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupList()
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00037568 File Offset: 0x00035768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupList(ChallengeLineupList other) : this()
		{
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00037592 File Offset: 0x00035792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupList Clone()
		{
			return new ChallengeLineupList(this);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0003759A File Offset: 0x0003579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeAvatarInfo> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000375A2 File Offset: 0x000357A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeLineupList);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000375B0 File Offset: 0x000357B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeLineupList other)
		{
			return other != null && (other == this || (this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000375E4 File Offset: 0x000357E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00037618 File Offset: 0x00035818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00037620 File Offset: 0x00035820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00037629 File Offset: 0x00035829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, ChallengeLineupList._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00037650 File Offset: 0x00035850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarList_.CalculateSize(ChallengeLineupList._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00037689 File Offset: 0x00035889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeLineupList other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000376B7 File Offset: 0x000358B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000376C0 File Offset: 0x000358C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avatarList_.AddEntriesFrom(ref input, ChallengeLineupList._repeated_avatarList_codec);
				}
			}
		}

		// Token: 0x04000815 RID: 2069
		private static readonly MessageParser<ChallengeLineupList> _parser = new MessageParser<ChallengeLineupList>(() => new ChallengeLineupList());

		// Token: 0x04000816 RID: 2070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000817 RID: 2071
		public const int AvatarListFieldNumber = 9;

		// Token: 0x04000818 RID: 2072
		private static readonly FieldCodec<ChallengeAvatarInfo> _repeated_avatarList_codec = FieldCodec.ForMessage<ChallengeAvatarInfo>(74U, ChallengeAvatarInfo.Parser);

		// Token: 0x04000819 RID: 2073
		private readonly RepeatedField<ChallengeAvatarInfo> avatarList_ = new RepeatedField<ChallengeAvatarInfo>();
	}
}
