using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A63 RID: 2659
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LogisticsDetonateStarSkiffScRsp : IMessage<LogisticsDetonateStarSkiffScRsp>, IMessage, IEquatable<LogisticsDetonateStarSkiffScRsp>, IDeepCloneable<LogisticsDetonateStarSkiffScRsp>, IBufferMessage
	{
		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x060075E0 RID: 30176 RVA: 0x00138E04 File Offset: 0x00137004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LogisticsDetonateStarSkiffScRsp> Parser
		{
			get
			{
				return LogisticsDetonateStarSkiffScRsp._parser;
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x060075E1 RID: 30177 RVA: 0x00138E0B File Offset: 0x0013700B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LogisticsDetonateStarSkiffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x00138E1D File Offset: 0x0013701D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogisticsDetonateStarSkiffScRsp.Descriptor;
			}
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00138E24 File Offset: 0x00137024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffScRsp()
		{
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00138E2C File Offset: 0x0013702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffScRsp(LogisticsDetonateStarSkiffScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00138E51 File Offset: 0x00137051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogisticsDetonateStarSkiffScRsp Clone()
		{
			return new LogisticsDetonateStarSkiffScRsp(this);
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x060075E6 RID: 30182 RVA: 0x00138E59 File Offset: 0x00137059
		// (set) Token: 0x060075E7 RID: 30183 RVA: 0x00138E61 File Offset: 0x00137061
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

		// Token: 0x060075E8 RID: 30184 RVA: 0x00138E6A File Offset: 0x0013706A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogisticsDetonateStarSkiffScRsp);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00138E78 File Offset: 0x00137078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogisticsDetonateStarSkiffScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00138EA8 File Offset: 0x001370A8
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

		// Token: 0x060075EB RID: 30187 RVA: 0x00138EE7 File Offset: 0x001370E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00138EEF File Offset: 0x001370EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00138EF8 File Offset: 0x001370F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00138F2C File Offset: 0x0013712C
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

		// Token: 0x060075EF RID: 30191 RVA: 0x00138F6A File Offset: 0x0013716A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogisticsDetonateStarSkiffScRsp other)
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

		// Token: 0x060075F0 RID: 30192 RVA: 0x00138F9B File Offset: 0x0013719B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00138FA4 File Offset: 0x001371A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D4E RID: 11598
		private static readonly MessageParser<LogisticsDetonateStarSkiffScRsp> _parser = new MessageParser<LogisticsDetonateStarSkiffScRsp>(() => new LogisticsDetonateStarSkiffScRsp());

		// Token: 0x04002D4F RID: 11599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D50 RID: 11600
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04002D51 RID: 11601
		private uint retcode_;
	}
}
