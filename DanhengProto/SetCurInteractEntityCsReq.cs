using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E1 RID: 4321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetCurInteractEntityCsReq : IMessage<SetCurInteractEntityCsReq>, IMessage, IEquatable<SetCurInteractEntityCsReq>, IDeepCloneable<SetCurInteractEntityCsReq>, IBufferMessage
	{
		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x002065C0 File Offset: 0x002047C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetCurInteractEntityCsReq> Parser
		{
			get
			{
				return SetCurInteractEntityCsReq._parser;
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600C0AF RID: 49327 RVA: 0x002065C7 File Offset: 0x002047C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetCurInteractEntityCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x002065D9 File Offset: 0x002047D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetCurInteractEntityCsReq.Descriptor;
			}
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x002065E0 File Offset: 0x002047E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityCsReq()
		{
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x002065E8 File Offset: 0x002047E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityCsReq(SetCurInteractEntityCsReq other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x0020660D File Offset: 0x0020480D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurInteractEntityCsReq Clone()
		{
			return new SetCurInteractEntityCsReq(this);
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600C0B4 RID: 49332 RVA: 0x00206615 File Offset: 0x00204815
		// (set) Token: 0x0600C0B5 RID: 49333 RVA: 0x0020661D File Offset: 0x0020481D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x00206626 File Offset: 0x00204826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetCurInteractEntityCsReq);
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x00206634 File Offset: 0x00204834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetCurInteractEntityCsReq other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0B8 RID: 49336 RVA: 0x00206664 File Offset: 0x00204864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0B9 RID: 49337 RVA: 0x002066A3 File Offset: 0x002048A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x002066AB File Offset: 0x002048AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x002066B4 File Offset: 0x002048B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0BC RID: 49340 RVA: 0x002066E8 File Offset: 0x002048E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x00206726 File Offset: 0x00204926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetCurInteractEntityCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x00206757 File Offset: 0x00204957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x00206760 File Offset: 0x00204960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E1D RID: 19997
		private static readonly MessageParser<SetCurInteractEntityCsReq> _parser = new MessageParser<SetCurInteractEntityCsReq>(() => new SetCurInteractEntityCsReq());

		// Token: 0x04004E1E RID: 19998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E1F RID: 19999
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04004E20 RID: 20000
		private uint entityId_;
	}
}
