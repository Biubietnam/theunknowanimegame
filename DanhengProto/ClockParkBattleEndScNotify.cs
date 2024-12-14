using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E7 RID: 743
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkBattleEndScNotify : IMessage<ClockParkBattleEndScNotify>, IMessage, IEquatable<ClockParkBattleEndScNotify>, IDeepCloneable<ClockParkBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0005E32D File Offset: 0x0005C52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkBattleEndScNotify> Parser
		{
			get
			{
				return ClockParkBattleEndScNotify._parser;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0005E334 File Offset: 0x0005C534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x0005E346 File Offset: 0x0005C546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0005E34D File Offset: 0x0005C54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkBattleEndScNotify()
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0005E355 File Offset: 0x0005C555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkBattleEndScNotify(ClockParkBattleEndScNotify other) : this()
		{
			this.retcode_ = other.retcode_;
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0005E386 File Offset: 0x0005C586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkBattleEndScNotify Clone()
		{
			return new ClockParkBattleEndScNotify(this);
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x0005E38E File Offset: 0x0005C58E
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x0005E396 File Offset: 0x0005C596
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x0005E39F File Offset: 0x0005C59F
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x0005E3A7 File Offset: 0x0005C5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HIAGEINLAHL
		{
			get
			{
				return this.hIAGEINLAHL_;
			}
			set
			{
				this.hIAGEINLAHL_ = value;
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkBattleEndScNotify);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0005E3BE File Offset: 0x0005C5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkBattleEndScNotify other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.HIAGEINLAHL == other.HIAGEINLAHL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0005E454 File Offset: 0x0005C654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0005E45C File Offset: 0x0005C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x0005E468 File Offset: 0x0005C668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0005E4C4 File Offset: 0x0005C6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0005E51C File Offset: 0x0005C71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0005E56C File Offset: 0x0005C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x0005E578 File Offset: 0x0005C778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HIAGEINLAHL = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000DA9 RID: 3497
		private static readonly MessageParser<ClockParkBattleEndScNotify> _parser = new MessageParser<ClockParkBattleEndScNotify>(() => new ClockParkBattleEndScNotify());

		// Token: 0x04000DAA RID: 3498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DAB RID: 3499
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04000DAC RID: 3500
		private uint retcode_;

		// Token: 0x04000DAD RID: 3501
		public const int HIAGEINLAHLFieldNumber = 11;

		// Token: 0x04000DAE RID: 3502
		private uint hIAGEINLAHL_;
	}
}
