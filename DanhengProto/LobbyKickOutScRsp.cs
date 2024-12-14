using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A47 RID: 2631
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyKickOutScRsp : IMessage<LobbyKickOutScRsp>, IMessage, IEquatable<LobbyKickOutScRsp>, IDeepCloneable<LobbyKickOutScRsp>, IBufferMessage
	{
		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x060074C1 RID: 29889 RVA: 0x00136654 File Offset: 0x00134854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyKickOutScRsp> Parser
		{
			get
			{
				return LobbyKickOutScRsp._parser;
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0013665B File Offset: 0x0013485B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyKickOutScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x0013666D File Offset: 0x0013486D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyKickOutScRsp.Descriptor;
			}
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00136674 File Offset: 0x00134874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutScRsp()
		{
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0013667C File Offset: 0x0013487C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutScRsp(LobbyKickOutScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x001366A1 File Offset: 0x001348A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyKickOutScRsp Clone()
		{
			return new LobbyKickOutScRsp(this);
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x060074C7 RID: 29895 RVA: 0x001366A9 File Offset: 0x001348A9
		// (set) Token: 0x060074C8 RID: 29896 RVA: 0x001366B1 File Offset: 0x001348B1
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

		// Token: 0x060074C9 RID: 29897 RVA: 0x001366BA File Offset: 0x001348BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyKickOutScRsp);
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x001366C8 File Offset: 0x001348C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyKickOutScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x001366F8 File Offset: 0x001348F8
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

		// Token: 0x060074CC RID: 29900 RVA: 0x00136737 File Offset: 0x00134937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0013673F File Offset: 0x0013493F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x00136748 File Offset: 0x00134948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x0013677C File Offset: 0x0013497C
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

		// Token: 0x060074D0 RID: 29904 RVA: 0x001367BA File Offset: 0x001349BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyKickOutScRsp other)
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

		// Token: 0x060074D1 RID: 29905 RVA: 0x001367EB File Offset: 0x001349EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x001367F4 File Offset: 0x001349F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002CE7 RID: 11495
		private static readonly MessageParser<LobbyKickOutScRsp> _parser = new MessageParser<LobbyKickOutScRsp>(() => new LobbyKickOutScRsp());

		// Token: 0x04002CE8 RID: 11496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CE9 RID: 11497
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04002CEA RID: 11498
		private uint retcode_;
	}
}
