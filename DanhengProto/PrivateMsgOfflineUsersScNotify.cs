using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D03 RID: 3331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrivateMsgOfflineUsersScNotify : IMessage<PrivateMsgOfflineUsersScNotify>, IMessage, IEquatable<PrivateMsgOfflineUsersScNotify>, IDeepCloneable<PrivateMsgOfflineUsersScNotify>, IBufferMessage
	{
		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x060094CF RID: 38095 RVA: 0x0018B95D File Offset: 0x00189B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivateMsgOfflineUsersScNotify> Parser
		{
			get
			{
				return PrivateMsgOfflineUsersScNotify._parser;
			}
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x060094D0 RID: 38096 RVA: 0x0018B964 File Offset: 0x00189B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrivateMsgOfflineUsersScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x060094D1 RID: 38097 RVA: 0x0018B976 File Offset: 0x00189B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateMsgOfflineUsersScNotify.Descriptor;
			}
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x0018B97D File Offset: 0x00189B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMsgOfflineUsersScNotify()
		{
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x0018B990 File Offset: 0x00189B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMsgOfflineUsersScNotify(PrivateMsgOfflineUsersScNotify other) : this()
		{
			this.contactIdList_ = other.contactIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x0018B9BA File Offset: 0x00189BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateMsgOfflineUsersScNotify Clone()
		{
			return new PrivateMsgOfflineUsersScNotify(this);
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x060094D5 RID: 38101 RVA: 0x0018B9C2 File Offset: 0x00189BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ContactIdList
		{
			get
			{
				return this.contactIdList_;
			}
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x0018B9CA File Offset: 0x00189BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateMsgOfflineUsersScNotify);
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x0018B9D8 File Offset: 0x00189BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateMsgOfflineUsersScNotify other)
		{
			return other != null && (other == this || (this.contactIdList_.Equals(other.contactIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x0018BA0C File Offset: 0x00189C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.contactIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x0018BA40 File Offset: 0x00189C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x0018BA48 File Offset: 0x00189C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x0018BA51 File Offset: 0x00189C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contactIdList_.WriteTo(ref output, PrivateMsgOfflineUsersScNotify._repeated_contactIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x0018BA78 File Offset: 0x00189C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.contactIdList_.CalculateSize(PrivateMsgOfflineUsersScNotify._repeated_contactIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x0018BAB1 File Offset: 0x00189CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateMsgOfflineUsersScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.contactIdList_.Add(other.contactIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x0018BADF File Offset: 0x00189CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x0018BAE8 File Offset: 0x00189CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.contactIdList_.AddEntriesFrom(ref input, PrivateMsgOfflineUsersScNotify._repeated_contactIdList_codec);
				}
			}
		}

		// Token: 0x040039A2 RID: 14754
		private static readonly MessageParser<PrivateMsgOfflineUsersScNotify> _parser = new MessageParser<PrivateMsgOfflineUsersScNotify>(() => new PrivateMsgOfflineUsersScNotify());

		// Token: 0x040039A3 RID: 14755
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039A4 RID: 14756
		public const int ContactIdListFieldNumber = 7;

		// Token: 0x040039A5 RID: 14757
		private static readonly FieldCodec<uint> _repeated_contactIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x040039A6 RID: 14758
		private readonly RepeatedField<uint> contactIdList_ = new RepeatedField<uint>();
	}
}
