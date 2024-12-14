using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD5 RID: 3029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MuseumTargetStartNotify : IMessage<MuseumTargetStartNotify>, IMessage, IEquatable<MuseumTargetStartNotify>, IDeepCloneable<MuseumTargetStartNotify>, IBufferMessage
	{
		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06008607 RID: 34311 RVA: 0x00161CBC File Offset: 0x0015FEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MuseumTargetStartNotify> Parser
		{
			get
			{
				return MuseumTargetStartNotify._parser;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x06008608 RID: 34312 RVA: 0x00161CC3 File Offset: 0x0015FEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MuseumTargetStartNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00161CD5 File Offset: 0x0015FED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MuseumTargetStartNotify.Descriptor;
			}
		}

		// Token: 0x0600860A RID: 34314 RVA: 0x00161CDC File Offset: 0x0015FEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetStartNotify()
		{
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00161CE4 File Offset: 0x0015FEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetStartNotify(MuseumTargetStartNotify other) : this()
		{
			this.pHLFJPFKFOF_ = other.pHLFJPFKFOF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600860C RID: 34316 RVA: 0x00161D09 File Offset: 0x0015FF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MuseumTargetStartNotify Clone()
		{
			return new MuseumTargetStartNotify(this);
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x00161D11 File Offset: 0x0015FF11
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x00161D19 File Offset: 0x0015FF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHLFJPFKFOF
		{
			get
			{
				return this.pHLFJPFKFOF_;
			}
			set
			{
				this.pHLFJPFKFOF_ = value;
			}
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x00161D22 File Offset: 0x0015FF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MuseumTargetStartNotify);
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00161D30 File Offset: 0x0015FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MuseumTargetStartNotify other)
		{
			return other != null && (other == this || (this.PHLFJPFKFOF == other.PHLFJPFKFOF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x00161D60 File Offset: 0x0015FF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHLFJPFKFOF != 0U)
			{
				num ^= this.PHLFJPFKFOF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x00161D9F File Offset: 0x0015FF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x00161DA7 File Offset: 0x0015FFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x00161DB0 File Offset: 0x0015FFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHLFJPFKFOF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PHLFJPFKFOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008615 RID: 34325 RVA: 0x00161DE4 File Offset: 0x0015FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHLFJPFKFOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHLFJPFKFOF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x00161E22 File Offset: 0x00160022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MuseumTargetStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHLFJPFKFOF != 0U)
			{
				this.PHLFJPFKFOF = other.PHLFJPFKFOF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x00161E53 File Offset: 0x00160053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x00161E5C File Offset: 0x0016005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PHLFJPFKFOF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003356 RID: 13142
		private static readonly MessageParser<MuseumTargetStartNotify> _parser = new MessageParser<MuseumTargetStartNotify>(() => new MuseumTargetStartNotify());

		// Token: 0x04003357 RID: 13143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003358 RID: 13144
		public const int PHLFJPFKFOFFieldNumber = 12;

		// Token: 0x04003359 RID: 13145
		private uint pHLFJPFKFOF_;
	}
}
