using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A5B RID: 2651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockRelicScRsp : IMessage<LockRelicScRsp>, IMessage, IEquatable<LockRelicScRsp>, IDeepCloneable<LockRelicScRsp>, IBufferMessage
	{
		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06007589 RID: 30089 RVA: 0x00138254 File Offset: 0x00136454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockRelicScRsp> Parser
		{
			get
			{
				return LockRelicScRsp._parser;
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x0013825B File Offset: 0x0013645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LockRelicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600758B RID: 30091 RVA: 0x0013826D File Offset: 0x0013646D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LockRelicScRsp.Descriptor;
			}
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00138274 File Offset: 0x00136474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicScRsp()
		{
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x0013827C File Offset: 0x0013647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicScRsp(LockRelicScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x001382A1 File Offset: 0x001364A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockRelicScRsp Clone()
		{
			return new LockRelicScRsp(this);
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600758F RID: 30095 RVA: 0x001382A9 File Offset: 0x001364A9
		// (set) Token: 0x06007590 RID: 30096 RVA: 0x001382B1 File Offset: 0x001364B1
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

		// Token: 0x06007591 RID: 30097 RVA: 0x001382BA File Offset: 0x001364BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LockRelicScRsp);
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x001382C8 File Offset: 0x001364C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LockRelicScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x001382F8 File Offset: 0x001364F8
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

		// Token: 0x06007594 RID: 30100 RVA: 0x00138337 File Offset: 0x00136537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x0013833F File Offset: 0x0013653F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00138348 File Offset: 0x00136548
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

		// Token: 0x06007597 RID: 30103 RVA: 0x0013837C File Offset: 0x0013657C
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

		// Token: 0x06007598 RID: 30104 RVA: 0x001383BA File Offset: 0x001365BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LockRelicScRsp other)
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

		// Token: 0x06007599 RID: 30105 RVA: 0x001383EB File Offset: 0x001365EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x001383F4 File Offset: 0x001365F4
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

		// Token: 0x04002D35 RID: 11573
		private static readonly MessageParser<LockRelicScRsp> _parser = new MessageParser<LockRelicScRsp>(() => new LockRelicScRsp());

		// Token: 0x04002D36 RID: 11574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D37 RID: 11575
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04002D38 RID: 11576
		private uint retcode_;
	}
}
