using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000EB RID: 235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleLogReportScRsp : IMessage<BattleLogReportScRsp>, IMessage, IEquatable<BattleLogReportScRsp>, IDeepCloneable<BattleLogReportScRsp>, IBufferMessage
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0001EACD File Offset: 0x0001CCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleLogReportScRsp> Parser
		{
			get
			{
				return BattleLogReportScRsp._parser;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleLogReportScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0001EAE6 File Offset: 0x0001CCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleLogReportScRsp.Descriptor;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001EAED File Offset: 0x0001CCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportScRsp()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001EAF5 File Offset: 0x0001CCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportScRsp(BattleLogReportScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.isBattleLogReport_ = other.isBattleLogReport_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001EB26 File Offset: 0x0001CD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleLogReportScRsp Clone()
		{
			return new BattleLogReportScRsp(this);
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0001EB2E File Offset: 0x0001CD2E
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0001EB36 File Offset: 0x0001CD36
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0001EB3F File Offset: 0x0001CD3F
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0001EB47 File Offset: 0x0001CD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBattleLogReport
		{
			get
			{
				return this.isBattleLogReport_;
			}
			set
			{
				this.isBattleLogReport_ = value;
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0001EB50 File Offset: 0x0001CD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleLogReportScRsp);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001EB5E File Offset: 0x0001CD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleLogReportScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.IsBattleLogReport == other.IsBattleLogReport && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001EB9C File Offset: 0x0001CD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IsBattleLogReport)
			{
				num ^= this.IsBattleLogReport.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001EBF4 File Offset: 0x0001CDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001EC08 File Offset: 0x0001CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IsBattleLogReport)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsBattleLogReport);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001EC64 File Offset: 0x0001CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IsBattleLogReport)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleLogReportScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IsBattleLogReport)
			{
				this.IsBattleLogReport = other.IsBattleLogReport;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0001ED00 File Offset: 0x0001CF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0001ED0C File Offset: 0x0001CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsBattleLogReport = input.ReadBool();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000453 RID: 1107
		private static readonly MessageParser<BattleLogReportScRsp> _parser = new MessageParser<BattleLogReportScRsp>(() => new BattleLogReportScRsp());

		// Token: 0x04000454 RID: 1108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000455 RID: 1109
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000456 RID: 1110
		private uint retcode_;

		// Token: 0x04000457 RID: 1111
		public const int IsBattleLogReportFieldNumber = 6;

		// Token: 0x04000458 RID: 1112
		private bool isBattleLogReport_;
	}
}
