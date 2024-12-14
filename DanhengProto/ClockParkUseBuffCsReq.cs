using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000305 RID: 773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkUseBuffCsReq : IMessage<ClockParkUseBuffCsReq>, IMessage, IEquatable<ClockParkUseBuffCsReq>, IDeepCloneable<ClockParkUseBuffCsReq>, IBufferMessage
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0006223D File Offset: 0x0006043D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkUseBuffCsReq> Parser
		{
			get
			{
				return ClockParkUseBuffCsReq._parser;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00062244 File Offset: 0x00060444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkUseBuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00062256 File Offset: 0x00060456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkUseBuffCsReq.Descriptor;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0006225D File Offset: 0x0006045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffCsReq()
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00062265 File Offset: 0x00060465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffCsReq(ClockParkUseBuffCsReq other) : this()
		{
			this.hIAGEINLAHL_ = other.hIAGEINLAHL_;
			this.uniqueId_ = other.uniqueId_;
			this.scriptId_ = other.scriptId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000622A2 File Offset: 0x000604A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUseBuffCsReq Clone()
		{
			return new ClockParkUseBuffCsReq(this);
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x000622AA File Offset: 0x000604AA
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x000622B2 File Offset: 0x000604B2
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000622BB File Offset: 0x000604BB
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x000622C3 File Offset: 0x000604C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000622CC File Offset: 0x000604CC
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x000622D4 File Offset: 0x000604D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000622DD File Offset: 0x000604DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkUseBuffCsReq);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000622EC File Offset: 0x000604EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkUseBuffCsReq other)
		{
			return other != null && (other == this || (this.HIAGEINLAHL == other.HIAGEINLAHL && this.UniqueId == other.UniqueId && this.ScriptId == other.ScriptId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00062348 File Offset: 0x00060548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HIAGEINLAHL != 0U)
			{
				num ^= this.HIAGEINLAHL.GetHashCode();
			}
			if (this.UniqueId != 0UL)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000623B9 File Offset: 0x000605B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000623C1 File Offset: 0x000605C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000623CC File Offset: 0x000605CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HIAGEINLAHL != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.HIAGEINLAHL);
			}
			if (this.UniqueId != 0UL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UniqueId);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00062444 File Offset: 0x00060644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HIAGEINLAHL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HIAGEINLAHL);
			}
			if (this.UniqueId != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000624B4 File Offset: 0x000606B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkUseBuffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HIAGEINLAHL != 0U)
			{
				this.HIAGEINLAHL = other.HIAGEINLAHL;
			}
			if (other.UniqueId != 0UL)
			{
				this.UniqueId = other.UniqueId;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00062518 File Offset: 0x00060718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00062524 File Offset: 0x00060724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ScriptId = input.ReadUInt32();
						}
					}
					else
					{
						this.UniqueId = input.ReadUInt64();
					}
				}
				else
				{
					this.HIAGEINLAHL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E3B RID: 3643
		private static readonly MessageParser<ClockParkUseBuffCsReq> _parser = new MessageParser<ClockParkUseBuffCsReq>(() => new ClockParkUseBuffCsReq());

		// Token: 0x04000E3C RID: 3644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E3D RID: 3645
		public const int HIAGEINLAHLFieldNumber = 5;

		// Token: 0x04000E3E RID: 3646
		private uint hIAGEINLAHL_;

		// Token: 0x04000E3F RID: 3647
		public const int UniqueIdFieldNumber = 6;

		// Token: 0x04000E40 RID: 3648
		private ulong uniqueId_;

		// Token: 0x04000E41 RID: 3649
		public const int ScriptIdFieldNumber = 15;

		// Token: 0x04000E42 RID: 3650
		private uint scriptId_;
	}
}
