using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010ED RID: 4333
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetForbidOtherApplyFriendCsReq : IMessage<SetForbidOtherApplyFriendCsReq>, IMessage, IEquatable<SetForbidOtherApplyFriendCsReq>, IDeepCloneable<SetForbidOtherApplyFriendCsReq>, IBufferMessage
	{
		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600C12E RID: 49454 RVA: 0x0020762C File Offset: 0x0020582C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetForbidOtherApplyFriendCsReq> Parser
		{
			get
			{
				return SetForbidOtherApplyFriendCsReq._parser;
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600C12F RID: 49455 RVA: 0x00207633 File Offset: 0x00205833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetForbidOtherApplyFriendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600C130 RID: 49456 RVA: 0x00207645 File Offset: 0x00205845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetForbidOtherApplyFriendCsReq.Descriptor;
			}
		}

		// Token: 0x0600C131 RID: 49457 RVA: 0x0020764C File Offset: 0x0020584C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendCsReq()
		{
		}

		// Token: 0x0600C132 RID: 49458 RVA: 0x00207654 File Offset: 0x00205854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendCsReq(SetForbidOtherApplyFriendCsReq other) : this()
		{
			this.nDBCIOELLJL_ = other.nDBCIOELLJL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C133 RID: 49459 RVA: 0x00207679 File Offset: 0x00205879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendCsReq Clone()
		{
			return new SetForbidOtherApplyFriendCsReq(this);
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600C134 RID: 49460 RVA: 0x00207681 File Offset: 0x00205881
		// (set) Token: 0x0600C135 RID: 49461 RVA: 0x00207689 File Offset: 0x00205889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NDBCIOELLJL
		{
			get
			{
				return this.nDBCIOELLJL_;
			}
			set
			{
				this.nDBCIOELLJL_ = value;
			}
		}

		// Token: 0x0600C136 RID: 49462 RVA: 0x00207692 File Offset: 0x00205892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetForbidOtherApplyFriendCsReq);
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x002076A0 File Offset: 0x002058A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetForbidOtherApplyFriendCsReq other)
		{
			return other != null && (other == this || (this.NDBCIOELLJL == other.NDBCIOELLJL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C138 RID: 49464 RVA: 0x002076D0 File Offset: 0x002058D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NDBCIOELLJL)
			{
				num ^= this.NDBCIOELLJL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x0020770F File Offset: 0x0020590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x00207717 File Offset: 0x00205917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x00207720 File Offset: 0x00205920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NDBCIOELLJL)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NDBCIOELLJL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x00207754 File Offset: 0x00205954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NDBCIOELLJL)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x00207786 File Offset: 0x00205986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetForbidOtherApplyFriendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NDBCIOELLJL)
			{
				this.NDBCIOELLJL = other.NDBCIOELLJL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x002077B7 File Offset: 0x002059B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x002077C0 File Offset: 0x002059C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NDBCIOELLJL = input.ReadBool();
				}
			}
		}

		// Token: 0x04004E41 RID: 20033
		private static readonly MessageParser<SetForbidOtherApplyFriendCsReq> _parser = new MessageParser<SetForbidOtherApplyFriendCsReq>(() => new SetForbidOtherApplyFriendCsReq());

		// Token: 0x04004E42 RID: 20034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E43 RID: 20035
		public const int NDBCIOELLJLFieldNumber = 15;

		// Token: 0x04004E44 RID: 20036
		private bool nDBCIOELLJL_;
	}
}
