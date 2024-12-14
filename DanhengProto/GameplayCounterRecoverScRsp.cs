using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005DF RID: 1503
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameplayCounterRecoverScRsp : IMessage<GameplayCounterRecoverScRsp>, IMessage, IEquatable<GameplayCounterRecoverScRsp>, IDeepCloneable<GameplayCounterRecoverScRsp>, IBufferMessage
	{
		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x000B6B64 File Offset: 0x000B4D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayCounterRecoverScRsp> Parser
		{
			get
			{
				return GameplayCounterRecoverScRsp._parser;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x000B6B6B File Offset: 0x000B4D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameplayCounterRecoverScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x000B6B7D File Offset: 0x000B4D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCounterRecoverScRsp.Descriptor;
			}
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x000B6B84 File Offset: 0x000B4D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverScRsp()
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000B6B8C File Offset: 0x000B4D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverScRsp(GameplayCounterRecoverScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000B6BB1 File Offset: 0x000B4DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverScRsp Clone()
		{
			return new GameplayCounterRecoverScRsp(this);
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x000B6BB9 File Offset: 0x000B4DB9
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x000B6BC1 File Offset: 0x000B4DC1
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

		// Token: 0x06004326 RID: 17190 RVA: 0x000B6BCA File Offset: 0x000B4DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCounterRecoverScRsp);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCounterRecoverScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000B6C08 File Offset: 0x000B4E08
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

		// Token: 0x06004329 RID: 17193 RVA: 0x000B6C47 File Offset: 0x000B4E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000B6C4F File Offset: 0x000B4E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000B6C58 File Offset: 0x000B4E58
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

		// Token: 0x0600432C RID: 17196 RVA: 0x000B6C8C File Offset: 0x000B4E8C
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

		// Token: 0x0600432D RID: 17197 RVA: 0x000B6CCA File Offset: 0x000B4ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCounterRecoverScRsp other)
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

		// Token: 0x0600432E RID: 17198 RVA: 0x000B6CFB File Offset: 0x000B4EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x000B6D04 File Offset: 0x000B4F04
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

		// Token: 0x04001AA2 RID: 6818
		private static readonly MessageParser<GameplayCounterRecoverScRsp> _parser = new MessageParser<GameplayCounterRecoverScRsp>(() => new GameplayCounterRecoverScRsp());

		// Token: 0x04001AA3 RID: 6819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AA4 RID: 6820
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001AA5 RID: 6821
		private uint retcode_;
	}
}
