using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE3 RID: 2787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionGroupWarnScNotify : IMessage<MissionGroupWarnScNotify>, IMessage, IEquatable<MissionGroupWarnScNotify>, IDeepCloneable<MissionGroupWarnScNotify>, IBufferMessage
	{
		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x00146B74 File Offset: 0x00144D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionGroupWarnScNotify> Parser
		{
			get
			{
				return MissionGroupWarnScNotify._parser;
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x00146B7B File Offset: 0x00144D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionGroupWarnScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x00146B8D File Offset: 0x00144D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionGroupWarnScNotify.Descriptor;
			}
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x00146B94 File Offset: 0x00144D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionGroupWarnScNotify()
		{
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x00146BA7 File Offset: 0x00144DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionGroupWarnScNotify(MissionGroupWarnScNotify other) : this()
		{
			this.groupIdList_ = other.groupIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x00146BD1 File Offset: 0x00144DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionGroupWarnScNotify Clone()
		{
			return new MissionGroupWarnScNotify(this);
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06007B79 RID: 31609 RVA: 0x00146BD9 File Offset: 0x00144DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> GroupIdList
		{
			get
			{
				return this.groupIdList_;
			}
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x00146BE1 File Offset: 0x00144DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionGroupWarnScNotify);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x00146BEF File Offset: 0x00144DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionGroupWarnScNotify other)
		{
			return other != null && (other == this || (this.groupIdList_.Equals(other.groupIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x00146C24 File Offset: 0x00144E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.groupIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x00146C58 File Offset: 0x00144E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x00146C60 File Offset: 0x00144E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x00146C69 File Offset: 0x00144E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.groupIdList_.WriteTo(ref output, MissionGroupWarnScNotify._repeated_groupIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x00146C90 File Offset: 0x00144E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.groupIdList_.CalculateSize(MissionGroupWarnScNotify._repeated_groupIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x00146CC9 File Offset: 0x00144EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionGroupWarnScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.groupIdList_.Add(other.groupIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x00146CF7 File Offset: 0x00144EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x00146D00 File Offset: 0x00144F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.groupIdList_.AddEntriesFrom(ref input, MissionGroupWarnScNotify._repeated_groupIdList_codec);
				}
			}
		}

		// Token: 0x04002F5A RID: 12122
		private static readonly MessageParser<MissionGroupWarnScNotify> _parser = new MessageParser<MissionGroupWarnScNotify>(() => new MissionGroupWarnScNotify());

		// Token: 0x04002F5B RID: 12123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F5C RID: 12124
		public const int GroupIdListFieldNumber = 3;

		// Token: 0x04002F5D RID: 12125
		private static readonly FieldCodec<uint> _repeated_groupIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002F5E RID: 12126
		private readonly RepeatedField<uint> groupIdList_ = new RepeatedField<uint>();
	}
}
