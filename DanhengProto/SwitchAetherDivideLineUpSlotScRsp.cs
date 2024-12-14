using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001217 RID: 4631
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwitchAetherDivideLineUpSlotScRsp : IMessage<SwitchAetherDivideLineUpSlotScRsp>, IMessage, IEquatable<SwitchAetherDivideLineUpSlotScRsp>, IDeepCloneable<SwitchAetherDivideLineUpSlotScRsp>, IBufferMessage
	{
		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x0022B0C5 File Offset: 0x002292C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwitchAetherDivideLineUpSlotScRsp> Parser
		{
			get
			{
				return SwitchAetherDivideLineUpSlotScRsp._parser;
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x0022B0CC File Offset: 0x002292CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwitchAetherDivideLineUpSlotScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600CF01 RID: 52993 RVA: 0x0022B0DE File Offset: 0x002292DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchAetherDivideLineUpSlotScRsp.Descriptor;
			}
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x0022B0E5 File Offset: 0x002292E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotScRsp()
		{
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x0022B0ED File Offset: 0x002292ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotScRsp(SwitchAetherDivideLineUpSlotScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lineupIndex_ = other.lineupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x0022B11E File Offset: 0x0022931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchAetherDivideLineUpSlotScRsp Clone()
		{
			return new SwitchAetherDivideLineUpSlotScRsp(this);
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600CF05 RID: 52997 RVA: 0x0022B126 File Offset: 0x00229326
		// (set) Token: 0x0600CF06 RID: 52998 RVA: 0x0022B12E File Offset: 0x0022932E
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

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600CF07 RID: 52999 RVA: 0x0022B137 File Offset: 0x00229337
		// (set) Token: 0x0600CF08 RID: 53000 RVA: 0x0022B13F File Offset: 0x0022933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LineupIndex
		{
			get
			{
				return this.lineupIndex_;
			}
			set
			{
				this.lineupIndex_ = value;
			}
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x0022B148 File Offset: 0x00229348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchAetherDivideLineUpSlotScRsp);
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x0022B156 File Offset: 0x00229356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchAetherDivideLineUpSlotScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.LineupIndex == other.LineupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x0022B194 File Offset: 0x00229394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LineupIndex != 0U)
			{
				num ^= this.LineupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x0022B1EC File Offset: 0x002293EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF0D RID: 53005 RVA: 0x0022B1F4 File Offset: 0x002293F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF0E RID: 53006 RVA: 0x0022B200 File Offset: 0x00229400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.LineupIndex != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.LineupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF0F RID: 53007 RVA: 0x0022B25C File Offset: 0x0022945C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LineupIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LineupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF10 RID: 53008 RVA: 0x0022B2B4 File Offset: 0x002294B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchAetherDivideLineUpSlotScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LineupIndex != 0U)
			{
				this.LineupIndex = other.LineupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF11 RID: 53009 RVA: 0x0022B304 File Offset: 0x00229504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF12 RID: 53010 RVA: 0x0022B310 File Offset: 0x00229510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LineupIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005355 RID: 21333
		private static readonly MessageParser<SwitchAetherDivideLineUpSlotScRsp> _parser = new MessageParser<SwitchAetherDivideLineUpSlotScRsp>(() => new SwitchAetherDivideLineUpSlotScRsp());

		// Token: 0x04005356 RID: 21334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005357 RID: 21335
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005358 RID: 21336
		private uint retcode_;

		// Token: 0x04005359 RID: 21337
		public const int LineupIndexFieldNumber = 15;

		// Token: 0x0400535A RID: 21338
		private uint lineupIndex_;
	}
}
