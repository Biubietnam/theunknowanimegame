using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001103 RID: 4355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGroupCustomSaveDataScRsp : IMessage<SetGroupCustomSaveDataScRsp>, IMessage, IEquatable<SetGroupCustomSaveDataScRsp>, IDeepCloneable<SetGroupCustomSaveDataScRsp>, IBufferMessage
	{
		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600C230 RID: 49712 RVA: 0x00209C29 File Offset: 0x00207E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGroupCustomSaveDataScRsp> Parser
		{
			get
			{
				return SetGroupCustomSaveDataScRsp._parser;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600C231 RID: 49713 RVA: 0x00209C30 File Offset: 0x00207E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600C232 RID: 49714 RVA: 0x00209C42 File Offset: 0x00207E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x00209C49 File Offset: 0x00207E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataScRsp()
		{
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x00209C51 File Offset: 0x00207E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataScRsp(SetGroupCustomSaveDataScRsp other) : this()
		{
			this.groupId_ = other.groupId_;
			this.retcode_ = other.retcode_;
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x00209C8E File Offset: 0x00207E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataScRsp Clone()
		{
			return new SetGroupCustomSaveDataScRsp(this);
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600C236 RID: 49718 RVA: 0x00209C96 File Offset: 0x00207E96
		// (set) Token: 0x0600C237 RID: 49719 RVA: 0x00209C9E File Offset: 0x00207E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600C238 RID: 49720 RVA: 0x00209CA7 File Offset: 0x00207EA7
		// (set) Token: 0x0600C239 RID: 49721 RVA: 0x00209CAF File Offset: 0x00207EAF
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

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600C23A RID: 49722 RVA: 0x00209CB8 File Offset: 0x00207EB8
		// (set) Token: 0x0600C23B RID: 49723 RVA: 0x00209CC0 File Offset: 0x00207EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x00209CC9 File Offset: 0x00207EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGroupCustomSaveDataScRsp);
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x00209CD8 File Offset: 0x00207ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGroupCustomSaveDataScRsp other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.Retcode == other.Retcode && this.EntryId == other.EntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x00209D34 File Offset: 0x00207F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x00209DA5 File Offset: 0x00207FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x00209DAD File Offset: 0x00207FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x00209DB8 File Offset: 0x00207FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EntryId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x00209E30 File Offset: 0x00208030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x00209EA0 File Offset: 0x002080A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGroupCustomSaveDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x00209F04 File Offset: 0x00208104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x00209F10 File Offset: 0x00208110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.EntryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E95 RID: 20117
		private static readonly MessageParser<SetGroupCustomSaveDataScRsp> _parser = new MessageParser<SetGroupCustomSaveDataScRsp>(() => new SetGroupCustomSaveDataScRsp());

		// Token: 0x04004E96 RID: 20118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E97 RID: 20119
		public const int GroupIdFieldNumber = 15;

		// Token: 0x04004E98 RID: 20120
		private uint groupId_;

		// Token: 0x04004E99 RID: 20121
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04004E9A RID: 20122
		private uint retcode_;

		// Token: 0x04004E9B RID: 20123
		public const int EntryIdFieldNumber = 3;

		// Token: 0x04004E9C RID: 20124
		private uint entryId_;
	}
}
