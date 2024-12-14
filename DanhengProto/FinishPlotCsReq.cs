using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200058B RID: 1419
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishPlotCsReq : IMessage<FinishPlotCsReq>, IMessage, IEquatable<FinishPlotCsReq>, IDeepCloneable<FinishPlotCsReq>, IBufferMessage
	{
		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x000ACE9C File Offset: 0x000AB09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishPlotCsReq> Parser
		{
			get
			{
				return FinishPlotCsReq._parser;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06003F56 RID: 16214 RVA: 0x000ACEA3 File Offset: 0x000AB0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishPlotCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x000ACEB5 File Offset: 0x000AB0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishPlotCsReq.Descriptor;
			}
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x000ACEBC File Offset: 0x000AB0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotCsReq()
		{
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x000ACEC4 File Offset: 0x000AB0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotCsReq(FinishPlotCsReq other) : this()
		{
			this.hACHMLAHNPC_ = other.hACHMLAHNPC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x000ACEE9 File Offset: 0x000AB0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishPlotCsReq Clone()
		{
			return new FinishPlotCsReq(this);
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x000ACEF1 File Offset: 0x000AB0F1
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x000ACEF9 File Offset: 0x000AB0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HACHMLAHNPC
		{
			get
			{
				return this.hACHMLAHNPC_;
			}
			set
			{
				this.hACHMLAHNPC_ = value;
			}
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x000ACF02 File Offset: 0x000AB102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishPlotCsReq);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000ACF10 File Offset: 0x000AB110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishPlotCsReq other)
		{
			return other != null && (other == this || (this.HACHMLAHNPC == other.HACHMLAHNPC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x000ACF40 File Offset: 0x000AB140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HACHMLAHNPC != 0U)
			{
				num ^= this.HACHMLAHNPC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x000ACF7F File Offset: 0x000AB17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000ACF87 File Offset: 0x000AB187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x000ACF90 File Offset: 0x000AB190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HACHMLAHNPC != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HACHMLAHNPC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x000ACFC4 File Offset: 0x000AB1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HACHMLAHNPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HACHMLAHNPC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x000AD002 File Offset: 0x000AB202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishPlotCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HACHMLAHNPC != 0U)
			{
				this.HACHMLAHNPC = other.HACHMLAHNPC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000AD033 File Offset: 0x000AB233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x000AD03C File Offset: 0x000AB23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HACHMLAHNPC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400193A RID: 6458
		private static readonly MessageParser<FinishPlotCsReq> _parser = new MessageParser<FinishPlotCsReq>(() => new FinishPlotCsReq());

		// Token: 0x0400193B RID: 6459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400193C RID: 6460
		public const int HACHMLAHNPCFieldNumber = 10;

		// Token: 0x0400193D RID: 6461
		private uint hACHMLAHNPC_;
	}
}
