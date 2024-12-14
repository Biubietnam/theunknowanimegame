using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087D RID: 2173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupStateChangeScNotify : IMessage<GroupStateChangeScNotify>, IMessage, IEquatable<GroupStateChangeScNotify>, IDeepCloneable<GroupStateChangeScNotify>, IBufferMessage
	{
		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x000FF755 File Offset: 0x000FD955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupStateChangeScNotify> Parser
		{
			get
			{
				return GroupStateChangeScNotify._parser;
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060060A0 RID: 24736 RVA: 0x000FF75C File Offset: 0x000FD95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x000FF76E File Offset: 0x000FD96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupStateChangeScNotify.Descriptor;
			}
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x000FF775 File Offset: 0x000FD975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScNotify()
		{
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x000FF77D File Offset: 0x000FD97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScNotify(GroupStateChangeScNotify other) : this()
		{
			this.groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x000FF7B2 File Offset: 0x000FD9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScNotify Clone()
		{
			return new GroupStateChangeScNotify(this);
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060060A5 RID: 24741 RVA: 0x000FF7BA File Offset: 0x000FD9BA
		// (set) Token: 0x060060A6 RID: 24742 RVA: 0x000FF7C2 File Offset: 0x000FD9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateInfo GroupStateInfo
		{
			get
			{
				return this.groupStateInfo_;
			}
			set
			{
				this.groupStateInfo_ = value;
			}
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x000FF7CB File Offset: 0x000FD9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupStateChangeScNotify);
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x000FF7D9 File Offset: 0x000FD9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupStateChangeScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GroupStateInfo, other.GroupStateInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x000FF80C File Offset: 0x000FDA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.groupStateInfo_ != null)
			{
				num ^= this.GroupStateInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x000FF848 File Offset: 0x000FDA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x000FF850 File Offset: 0x000FDA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x000FF859 File Offset: 0x000FDA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.groupStateInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GroupStateInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x000FF88C File Offset: 0x000FDA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.groupStateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupStateInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x000FF8CC File Offset: 0x000FDACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupStateChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.groupStateInfo_ != null)
			{
				if (this.groupStateInfo_ == null)
				{
					this.GroupStateInfo = new GroupStateInfo();
				}
				this.GroupStateInfo.MergeFrom(other.GroupStateInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x000FF920 File Offset: 0x000FDB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x000FF92C File Offset: 0x000FDB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.groupStateInfo_ == null)
					{
						this.GroupStateInfo = new GroupStateInfo();
					}
					input.ReadMessage(this.GroupStateInfo);
				}
			}
		}

		// Token: 0x04002525 RID: 9509
		private static readonly MessageParser<GroupStateChangeScNotify> _parser = new MessageParser<GroupStateChangeScNotify>(() => new GroupStateChangeScNotify());

		// Token: 0x04002526 RID: 9510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002527 RID: 9511
		public const int GroupStateInfoFieldNumber = 7;

		// Token: 0x04002528 RID: 9512
		private GroupStateInfo groupStateInfo_;
	}
}
