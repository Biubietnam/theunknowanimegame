using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B1B RID: 2843
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyClickMbtiReportScRsp : IMessage<MonopolyClickMbtiReportScRsp>, IMessage, IEquatable<MonopolyClickMbtiReportScRsp>, IDeepCloneable<MonopolyClickMbtiReportScRsp>, IBufferMessage
	{
		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x0014CEB8 File Offset: 0x0014B0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyClickMbtiReportScRsp> Parser
		{
			get
			{
				return MonopolyClickMbtiReportScRsp._parser;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x0014CEBF File Offset: 0x0014B0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyClickMbtiReportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06007DDA RID: 32218 RVA: 0x0014CED1 File Offset: 0x0014B0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyClickMbtiReportScRsp.Descriptor;
			}
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x0014CED8 File Offset: 0x0014B0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportScRsp()
		{
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x0014CEE0 File Offset: 0x0014B0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportScRsp(MonopolyClickMbtiReportScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x0014CF05 File Offset: 0x0014B105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickMbtiReportScRsp Clone()
		{
			return new MonopolyClickMbtiReportScRsp(this);
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06007DDE RID: 32222 RVA: 0x0014CF0D File Offset: 0x0014B10D
		// (set) Token: 0x06007DDF RID: 32223 RVA: 0x0014CF15 File Offset: 0x0014B115
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

		// Token: 0x06007DE0 RID: 32224 RVA: 0x0014CF1E File Offset: 0x0014B11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyClickMbtiReportScRsp);
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x0014CF2C File Offset: 0x0014B12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyClickMbtiReportScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x0014CF5C File Offset: 0x0014B15C
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

		// Token: 0x06007DE3 RID: 32227 RVA: 0x0014CF9B File Offset: 0x0014B19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x0014CFA3 File Offset: 0x0014B1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x0014CFAC File Offset: 0x0014B1AC
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

		// Token: 0x06007DE6 RID: 32230 RVA: 0x0014CFE0 File Offset: 0x0014B1E0
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

		// Token: 0x06007DE7 RID: 32231 RVA: 0x0014D01E File Offset: 0x0014B21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyClickMbtiReportScRsp other)
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

		// Token: 0x06007DE8 RID: 32232 RVA: 0x0014D04F File Offset: 0x0014B24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x0014D058 File Offset: 0x0014B258
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

		// Token: 0x0400304F RID: 12367
		private static readonly MessageParser<MonopolyClickMbtiReportScRsp> _parser = new MessageParser<MonopolyClickMbtiReportScRsp>(() => new MonopolyClickMbtiReportScRsp());

		// Token: 0x04003050 RID: 12368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003051 RID: 12369
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04003052 RID: 12370
		private uint retcode_;
	}
}
