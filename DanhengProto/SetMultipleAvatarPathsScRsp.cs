using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200111B RID: 4379
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMultipleAvatarPathsScRsp : IMessage<SetMultipleAvatarPathsScRsp>, IMessage, IEquatable<SetMultipleAvatarPathsScRsp>, IDeepCloneable<SetMultipleAvatarPathsScRsp>, IBufferMessage
	{
		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600C33D RID: 49981 RVA: 0x0020C0C0 File Offset: 0x0020A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMultipleAvatarPathsScRsp> Parser
		{
			get
			{
				return SetMultipleAvatarPathsScRsp._parser;
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600C33E RID: 49982 RVA: 0x0020C0C7 File Offset: 0x0020A2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetMultipleAvatarPathsScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600C33F RID: 49983 RVA: 0x0020C0D9 File Offset: 0x0020A2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMultipleAvatarPathsScRsp.Descriptor;
			}
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x0020C0E0 File Offset: 0x0020A2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsScRsp()
		{
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x0020C0E8 File Offset: 0x0020A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsScRsp(SetMultipleAvatarPathsScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x0020C10D File Offset: 0x0020A30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMultipleAvatarPathsScRsp Clone()
		{
			return new SetMultipleAvatarPathsScRsp(this);
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600C343 RID: 49987 RVA: 0x0020C115 File Offset: 0x0020A315
		// (set) Token: 0x0600C344 RID: 49988 RVA: 0x0020C11D File Offset: 0x0020A31D
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

		// Token: 0x0600C345 RID: 49989 RVA: 0x0020C126 File Offset: 0x0020A326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMultipleAvatarPathsScRsp);
		}

		// Token: 0x0600C346 RID: 49990 RVA: 0x0020C134 File Offset: 0x0020A334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMultipleAvatarPathsScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C347 RID: 49991 RVA: 0x0020C164 File Offset: 0x0020A364
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

		// Token: 0x0600C348 RID: 49992 RVA: 0x0020C1A3 File Offset: 0x0020A3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x0020C1AB File Offset: 0x0020A3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x0020C1B4 File Offset: 0x0020A3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x0020C1E8 File Offset: 0x0020A3E8
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

		// Token: 0x0600C34C RID: 49996 RVA: 0x0020C226 File Offset: 0x0020A426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMultipleAvatarPathsScRsp other)
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

		// Token: 0x0600C34D RID: 49997 RVA: 0x0020C257 File Offset: 0x0020A457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x0020C260 File Offset: 0x0020A460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004EE4 RID: 20196
		private static readonly MessageParser<SetMultipleAvatarPathsScRsp> _parser = new MessageParser<SetMultipleAvatarPathsScRsp>(() => new SetMultipleAvatarPathsScRsp());

		// Token: 0x04004EE5 RID: 20197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EE6 RID: 20198
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004EE7 RID: 20199
		private uint retcode_;
	}
}
