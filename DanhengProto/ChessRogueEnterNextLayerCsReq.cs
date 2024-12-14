using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000213 RID: 531
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterNextLayerCsReq : IMessage<ChessRogueEnterNextLayerCsReq>, IMessage, IEquatable<ChessRogueEnterNextLayerCsReq>, IDeepCloneable<ChessRogueEnterNextLayerCsReq>, IBufferMessage
	{
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00043E88 File Offset: 0x00042088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterNextLayerCsReq> Parser
		{
			get
			{
				return ChessRogueEnterNextLayerCsReq._parser;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00043E8F File Offset: 0x0004208F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterNextLayerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00043EA1 File Offset: 0x000420A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterNextLayerCsReq.Descriptor;
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00043EA8 File Offset: 0x000420A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerCsReq()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00043EB0 File Offset: 0x000420B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerCsReq(ChessRogueEnterNextLayerCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00043ED5 File Offset: 0x000420D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterNextLayerCsReq Clone()
		{
			return new ChessRogueEnterNextLayerCsReq(this);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00043EDD File Offset: 0x000420DD
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x00043EE5 File Offset: 0x000420E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00043EEE File Offset: 0x000420EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterNextLayerCsReq);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00043EFC File Offset: 0x000420FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterNextLayerCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00043F2C File Offset: 0x0004212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00043F6B File Offset: 0x0004216B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00043F73 File Offset: 0x00042173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00043F7C File Offset: 0x0004217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00043FB0 File Offset: 0x000421B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00043FEE File Offset: 0x000421EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterNextLayerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0004401F File Offset: 0x0004221F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00044028 File Offset: 0x00042228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000A05 RID: 2565
		private static readonly MessageParser<ChessRogueEnterNextLayerCsReq> _parser = new MessageParser<ChessRogueEnterNextLayerCsReq>(() => new ChessRogueEnterNextLayerCsReq());

		// Token: 0x04000A06 RID: 2566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A07 RID: 2567
		public const int PropEntityIdFieldNumber = 1;

		// Token: 0x04000A08 RID: 2568
		private uint propEntityId_;
	}
}
