using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200087F RID: 2175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupStateChangeScRsp : IMessage<GroupStateChangeScRsp>, IMessage, IEquatable<GroupStateChangeScRsp>, IDeepCloneable<GroupStateChangeScRsp>, IBufferMessage
	{
		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060060B4 RID: 24756 RVA: 0x000FFA21 File Offset: 0x000FDC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupStateChangeScRsp> Parser
		{
			get
			{
				return GroupStateChangeScRsp._parser;
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060060B5 RID: 24757 RVA: 0x000FFA28 File Offset: 0x000FDC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GroupStateChangeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060060B6 RID: 24758 RVA: 0x000FFA3A File Offset: 0x000FDC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GroupStateChangeScRsp.Descriptor;
			}
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x000FFA41 File Offset: 0x000FDC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScRsp()
		{
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x000FFA4C File Offset: 0x000FDC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScRsp(GroupStateChangeScRsp other) : this()
		{
			this.groupStateInfo_ = ((other.groupStateInfo_ != null) ? other.groupStateInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x000FFA98 File Offset: 0x000FDC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GroupStateChangeScRsp Clone()
		{
			return new GroupStateChangeScRsp(this);
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060060BA RID: 24762 RVA: 0x000FFAA0 File Offset: 0x000FDCA0
		// (set) Token: 0x060060BB RID: 24763 RVA: 0x000FFAA8 File Offset: 0x000FDCA8
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

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x060060BC RID: 24764 RVA: 0x000FFAB1 File Offset: 0x000FDCB1
		// (set) Token: 0x060060BD RID: 24765 RVA: 0x000FFAB9 File Offset: 0x000FDCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x000FFAC2 File Offset: 0x000FDCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GroupStateChangeScRsp);
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x000FFAD0 File Offset: 0x000FDCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GroupStateChangeScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GroupStateInfo, other.GroupStateInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x000FFB20 File Offset: 0x000FDD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.groupStateInfo_ != null)
			{
				num ^= this.GroupStateInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x000FFB75 File Offset: 0x000FDD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x000FFB7D File Offset: 0x000FDD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x000FFB88 File Offset: 0x000FDD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.groupStateInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GroupStateInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x000FFBE4 File Offset: 0x000FDDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.groupStateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupStateInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x000FFC3C File Offset: 0x000FDE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GroupStateChangeScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x000FFCA4 File Offset: 0x000FDEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x000FFCB0 File Offset: 0x000FDEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
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

		// Token: 0x0400252A RID: 9514
		private static readonly MessageParser<GroupStateChangeScRsp> _parser = new MessageParser<GroupStateChangeScRsp>(() => new GroupStateChangeScRsp());

		// Token: 0x0400252B RID: 9515
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400252C RID: 9516
		public const int GroupStateInfoFieldNumber = 4;

		// Token: 0x0400252D RID: 9517
		private GroupStateInfo groupStateInfo_;

		// Token: 0x0400252E RID: 9518
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400252F RID: 9519
		private uint retcode_;
	}
}
