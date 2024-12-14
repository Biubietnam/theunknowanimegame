using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A19 RID: 2585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LJHGBBKHAHO : IMessage<LJHGBBKHAHO>, IMessage, IEquatable<LJHGBBKHAHO>, IDeepCloneable<LJHGBBKHAHO>, IBufferMessage
	{
		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x00131E5C File Offset: 0x0013005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LJHGBBKHAHO> Parser
		{
			get
			{
				return LJHGBBKHAHO._parser;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x060072DF RID: 29407 RVA: 0x00131E63 File Offset: 0x00130063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LJHGBBKHAHOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x00131E75 File Offset: 0x00130075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LJHGBBKHAHO.Descriptor;
			}
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x00131E7C File Offset: 0x0013007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJHGBBKHAHO()
		{
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x00131E84 File Offset: 0x00130084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJHGBBKHAHO(LJHGBBKHAHO other) : this()
		{
			this.scepterId_ = other.scepterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00131EA9 File Offset: 0x001300A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJHGBBKHAHO Clone()
		{
			return new LJHGBBKHAHO(this);
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x00131EB1 File Offset: 0x001300B1
		// (set) Token: 0x060072E5 RID: 29413 RVA: 0x00131EB9 File Offset: 0x001300B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00131EC2 File Offset: 0x001300C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LJHGBBKHAHO);
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00131ED0 File Offset: 0x001300D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LJHGBBKHAHO other)
		{
			return other != null && (other == this || (this.ScepterId == other.ScepterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00131F00 File Offset: 0x00130100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00131F3F File Offset: 0x0013013F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x00131F47 File Offset: 0x00130147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00131F50 File Offset: 0x00130150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ScepterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00131F84 File Offset: 0x00130184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x00131FC2 File Offset: 0x001301C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LJHGBBKHAHO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072EE RID: 29422 RVA: 0x00131FF3 File Offset: 0x001301F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072EF RID: 29423 RVA: 0x00131FFC File Offset: 0x001301FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ScepterId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002C35 RID: 11317
		private static readonly MessageParser<LJHGBBKHAHO> _parser = new MessageParser<LJHGBBKHAHO>(() => new LJHGBBKHAHO());

		// Token: 0x04002C36 RID: 11318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C37 RID: 11319
		public const int ScepterIdFieldNumber = 6;

		// Token: 0x04002C38 RID: 11320
		private uint scepterId_;
	}
}
