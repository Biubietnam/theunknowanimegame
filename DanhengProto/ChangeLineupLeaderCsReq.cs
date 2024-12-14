using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C7 RID: 455
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeLineupLeaderCsReq : IMessage<ChangeLineupLeaderCsReq>, IMessage, IEquatable<ChangeLineupLeaderCsReq>, IDeepCloneable<ChangeLineupLeaderCsReq>, IBufferMessage
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0003ACFC File Offset: 0x00038EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeLineupLeaderCsReq> Parser
		{
			get
			{
				return ChangeLineupLeaderCsReq._parser;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0003AD03 File Offset: 0x00038F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChangeLineupLeaderCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0003AD15 File Offset: 0x00038F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeLineupLeaderCsReq.Descriptor;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0003AD1C File Offset: 0x00038F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderCsReq()
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0003AD24 File Offset: 0x00038F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderCsReq(ChangeLineupLeaderCsReq other) : this()
		{
			this.slot_ = other.slot_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0003AD49 File Offset: 0x00038F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderCsReq Clone()
		{
			return new ChangeLineupLeaderCsReq(this);
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0003AD51 File Offset: 0x00038F51
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0003AD59 File Offset: 0x00038F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0003AD62 File Offset: 0x00038F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeLineupLeaderCsReq);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0003AD70 File Offset: 0x00038F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeLineupLeaderCsReq other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0003ADA0 File Offset: 0x00038FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0003ADDF File Offset: 0x00038FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0003ADE7 File Offset: 0x00038FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Slot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0003AE24 File Offset: 0x00039024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0003AE62 File Offset: 0x00039062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeLineupLeaderCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0003AE93 File Offset: 0x00039093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0003AE9C File Offset: 0x0003909C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Slot = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000896 RID: 2198
		private static readonly MessageParser<ChangeLineupLeaderCsReq> _parser = new MessageParser<ChangeLineupLeaderCsReq>(() => new ChangeLineupLeaderCsReq());

		// Token: 0x04000897 RID: 2199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000898 RID: 2200
		public const int SlotFieldNumber = 15;

		// Token: 0x04000899 RID: 2201
		private uint slot_;
	}
}
