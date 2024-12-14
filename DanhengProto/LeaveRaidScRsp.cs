using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009FD RID: 2557
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveRaidScRsp : IMessage<LeaveRaidScRsp>, IMessage, IEquatable<LeaveRaidScRsp>, IDeepCloneable<LeaveRaidScRsp>, IBufferMessage
	{
		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x0012E110 File Offset: 0x0012C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveRaidScRsp> Parser
		{
			get
			{
				return LeaveRaidScRsp._parser;
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x0012E117 File Offset: 0x0012C317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x0012E129 File Offset: 0x0012C329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRaidScRsp.Descriptor;
			}
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x0012E130 File Offset: 0x0012C330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidScRsp()
		{
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x0012E138 File Offset: 0x0012C338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidScRsp(LeaveRaidScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x0012E15D File Offset: 0x0012C35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidScRsp Clone()
		{
			return new LeaveRaidScRsp(this);
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06007182 RID: 29058 RVA: 0x0012E165 File Offset: 0x0012C365
		// (set) Token: 0x06007183 RID: 29059 RVA: 0x0012E16D File Offset: 0x0012C36D
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

		// Token: 0x06007184 RID: 29060 RVA: 0x0012E176 File Offset: 0x0012C376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRaidScRsp);
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x0012E184 File Offset: 0x0012C384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveRaidScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x0012E1B4 File Offset: 0x0012C3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06007187 RID: 29063 RVA: 0x0012E1F3 File Offset: 0x0012C3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x0012E1FB File Offset: 0x0012C3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x0012E204 File Offset: 0x0012C404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x0012E238 File Offset: 0x0012C438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600718B RID: 29067 RVA: 0x0012E276 File Offset: 0x0012C476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x0012E2A7 File Offset: 0x0012C4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x0012E2B0 File Offset: 0x0012C4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002BA7 RID: 11175
		private static readonly MessageParser<LeaveRaidScRsp> _parser = new MessageParser<LeaveRaidScRsp>(() => new LeaveRaidScRsp());

		// Token: 0x04002BA8 RID: 11176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA9 RID: 11177
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002BAA RID: 11178
		private uint retcode_;
	}
}
