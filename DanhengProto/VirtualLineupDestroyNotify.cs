using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001415 RID: 5141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class VirtualLineupDestroyNotify : IMessage<VirtualLineupDestroyNotify>, IMessage, IEquatable<VirtualLineupDestroyNotify>, IDeepCloneable<VirtualLineupDestroyNotify>, IBufferMessage
	{
		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x0600E559 RID: 58713 RVA: 0x00261D80 File Offset: 0x0025FF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VirtualLineupDestroyNotify> Parser
		{
			get
			{
				return VirtualLineupDestroyNotify._parser;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x0600E55A RID: 58714 RVA: 0x00261D87 File Offset: 0x0025FF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VirtualLineupDestroyNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x0600E55B RID: 58715 RVA: 0x00261D99 File Offset: 0x0025FF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VirtualLineupDestroyNotify.Descriptor;
			}
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x00261DA0 File Offset: 0x0025FFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupDestroyNotify()
		{
		}

		// Token: 0x0600E55D RID: 58717 RVA: 0x00261DA8 File Offset: 0x0025FFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupDestroyNotify(VirtualLineupDestroyNotify other) : this()
		{
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E55E RID: 58718 RVA: 0x00261DCD File Offset: 0x0025FFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VirtualLineupDestroyNotify Clone()
		{
			return new VirtualLineupDestroyNotify(this);
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x0600E55F RID: 58719 RVA: 0x00261DD5 File Offset: 0x0025FFD5
		// (set) Token: 0x0600E560 RID: 58720 RVA: 0x00261DDD File Offset: 0x0025FFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00261DE6 File Offset: 0x0025FFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VirtualLineupDestroyNotify);
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x00261DF4 File Offset: 0x0025FFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VirtualLineupDestroyNotify other)
		{
			return other != null && (other == this || (this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x00261E24 File Offset: 0x00260024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x00261E63 File Offset: 0x00260063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x00261E6B File Offset: 0x0026006B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00261E74 File Offset: 0x00260074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00261EA8 File Offset: 0x002600A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x00261EE6 File Offset: 0x002600E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VirtualLineupDestroyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E569 RID: 58729 RVA: 0x00261F17 File Offset: 0x00260117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E56A RID: 58730 RVA: 0x00261F20 File Offset: 0x00260120
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
					this.PlaneId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B17 RID: 23319
		private static readonly MessageParser<VirtualLineupDestroyNotify> _parser = new MessageParser<VirtualLineupDestroyNotify>(() => new VirtualLineupDestroyNotify());

		// Token: 0x04005B18 RID: 23320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B19 RID: 23321
		public const int PlaneIdFieldNumber = 2;

		// Token: 0x04005B1A RID: 23322
		private uint planeId_;
	}
}
