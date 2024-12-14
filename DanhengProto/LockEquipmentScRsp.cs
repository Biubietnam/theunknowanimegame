using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A57 RID: 2647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockEquipmentScRsp : IMessage<LockEquipmentScRsp>, IMessage, IEquatable<LockEquipmentScRsp>, IDeepCloneable<LockEquipmentScRsp>, IBufferMessage
	{
		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x00137BF8 File Offset: 0x00135DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockEquipmentScRsp> Parser
		{
			get
			{
				return LockEquipmentScRsp._parser;
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600755D RID: 30045 RVA: 0x00137BFF File Offset: 0x00135DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LockEquipmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x00137C11 File Offset: 0x00135E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LockEquipmentScRsp.Descriptor;
			}
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00137C18 File Offset: 0x00135E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentScRsp()
		{
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00137C20 File Offset: 0x00135E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentScRsp(LockEquipmentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00137C45 File Offset: 0x00135E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentScRsp Clone()
		{
			return new LockEquipmentScRsp(this);
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x00137C4D File Offset: 0x00135E4D
		// (set) Token: 0x06007563 RID: 30051 RVA: 0x00137C55 File Offset: 0x00135E55
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

		// Token: 0x06007564 RID: 30052 RVA: 0x00137C5E File Offset: 0x00135E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LockEquipmentScRsp);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00137C6C File Offset: 0x00135E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LockEquipmentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00137C9C File Offset: 0x00135E9C
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

		// Token: 0x06007567 RID: 30055 RVA: 0x00137CDB File Offset: 0x00135EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x00137CE3 File Offset: 0x00135EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00137CEC File Offset: 0x00135EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00137D20 File Offset: 0x00135F20
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

		// Token: 0x0600756B RID: 30059 RVA: 0x00137D5E File Offset: 0x00135F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LockEquipmentScRsp other)
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

		// Token: 0x0600756C RID: 30060 RVA: 0x00137D8F File Offset: 0x00135F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00137D98 File Offset: 0x00135F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D26 RID: 11558
		private static readonly MessageParser<LockEquipmentScRsp> _parser = new MessageParser<LockEquipmentScRsp>(() => new LockEquipmentScRsp());

		// Token: 0x04002D27 RID: 11559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D28 RID: 11560
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002D29 RID: 11561
		private uint retcode_;
	}
}
