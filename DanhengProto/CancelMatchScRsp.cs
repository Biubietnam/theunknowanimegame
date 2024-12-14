using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200016B RID: 363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CancelMatchScRsp : IMessage<CancelMatchScRsp>, IMessage, IEquatable<CancelMatchScRsp>, IDeepCloneable<CancelMatchScRsp>, IBufferMessage
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0002EE58 File Offset: 0x0002D058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CancelMatchScRsp> Parser
		{
			get
			{
				return CancelMatchScRsp._parser;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0002EE5F File Offset: 0x0002D05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CancelMatchScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0002EE71 File Offset: 0x0002D071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchScRsp.Descriptor;
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002EE78 File Offset: 0x0002D078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchScRsp()
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002EE80 File Offset: 0x0002D080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchScRsp(CancelMatchScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002EEA5 File Offset: 0x0002D0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchScRsp Clone()
		{
			return new CancelMatchScRsp(this);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0002EEAD File Offset: 0x0002D0AD
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0002EEB5 File Offset: 0x0002D0B5
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

		// Token: 0x06001033 RID: 4147 RVA: 0x0002EEBE File Offset: 0x0002D0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchScRsp);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0002EECC File Offset: 0x0002D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0002EEFC File Offset: 0x0002D0FC
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

		// Token: 0x06001036 RID: 4150 RVA: 0x0002EF3B File Offset: 0x0002D13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0002EF43 File Offset: 0x0002D143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002EF4C File Offset: 0x0002D14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0002EF80 File Offset: 0x0002D180
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

		// Token: 0x0600103A RID: 4154 RVA: 0x0002EFBE File Offset: 0x0002D1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchScRsp other)
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

		// Token: 0x0600103B RID: 4155 RVA: 0x0002EFEF File Offset: 0x0002D1EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006D1 RID: 1745
		private static readonly MessageParser<CancelMatchScRsp> _parser = new MessageParser<CancelMatchScRsp>(() => new CancelMatchScRsp());

		// Token: 0x040006D2 RID: 1746
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006D3 RID: 1747
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040006D4 RID: 1748
		private uint retcode_;
	}
}
