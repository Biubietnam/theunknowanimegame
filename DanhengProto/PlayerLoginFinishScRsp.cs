using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC7 RID: 3271
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerLoginFinishScRsp : IMessage<PlayerLoginFinishScRsp>, IMessage, IEquatable<PlayerLoginFinishScRsp>, IDeepCloneable<PlayerLoginFinishScRsp>, IBufferMessage
	{
		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x060091D3 RID: 37331 RVA: 0x00182B38 File Offset: 0x00180D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerLoginFinishScRsp> Parser
		{
			get
			{
				return PlayerLoginFinishScRsp._parser;
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x060091D4 RID: 37332 RVA: 0x00182B3F File Offset: 0x00180D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerLoginFinishScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x060091D5 RID: 37333 RVA: 0x00182B51 File Offset: 0x00180D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerLoginFinishScRsp.Descriptor;
			}
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x00182B58 File Offset: 0x00180D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishScRsp()
		{
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00182B60 File Offset: 0x00180D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishScRsp(PlayerLoginFinishScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x00182B85 File Offset: 0x00180D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerLoginFinishScRsp Clone()
		{
			return new PlayerLoginFinishScRsp(this);
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x060091D9 RID: 37337 RVA: 0x00182B8D File Offset: 0x00180D8D
		// (set) Token: 0x060091DA RID: 37338 RVA: 0x00182B95 File Offset: 0x00180D95
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

		// Token: 0x060091DB RID: 37339 RVA: 0x00182B9E File Offset: 0x00180D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerLoginFinishScRsp);
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x00182BAC File Offset: 0x00180DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerLoginFinishScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00182BDC File Offset: 0x00180DDC
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

		// Token: 0x060091DE RID: 37342 RVA: 0x00182C1B File Offset: 0x00180E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00182C23 File Offset: 0x00180E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x00182C2C File Offset: 0x00180E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x00182C60 File Offset: 0x00180E60
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

		// Token: 0x060091E2 RID: 37346 RVA: 0x00182C9E File Offset: 0x00180E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerLoginFinishScRsp other)
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

		// Token: 0x060091E3 RID: 37347 RVA: 0x00182CCF File Offset: 0x00180ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x00182CD8 File Offset: 0x00180ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003843 RID: 14403
		private static readonly MessageParser<PlayerLoginFinishScRsp> _parser = new MessageParser<PlayerLoginFinishScRsp>(() => new PlayerLoginFinishScRsp());

		// Token: 0x04003844 RID: 14404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003845 RID: 14405
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04003846 RID: 14406
		private uint retcode_;
	}
}
