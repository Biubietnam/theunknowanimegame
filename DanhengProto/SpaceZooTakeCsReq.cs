using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001173 RID: 4467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooTakeCsReq : IMessage<SpaceZooTakeCsReq>, IMessage, IEquatable<SpaceZooTakeCsReq>, IDeepCloneable<SpaceZooTakeCsReq>, IBufferMessage
	{
		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600C74E RID: 51022 RVA: 0x00216E54 File Offset: 0x00215054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooTakeCsReq> Parser
		{
			get
			{
				return SpaceZooTakeCsReq._parser;
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600C74F RID: 51023 RVA: 0x00216E5B File Offset: 0x0021505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooTakeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600C750 RID: 51024 RVA: 0x00216E6D File Offset: 0x0021506D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooTakeCsReq.Descriptor;
			}
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x00216E74 File Offset: 0x00215074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeCsReq()
		{
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x00216E7C File Offset: 0x0021507C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeCsReq(SpaceZooTakeCsReq other) : this()
		{
			this.gDCODBCDKAA_ = other.gDCODBCDKAA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x00216EA1 File Offset: 0x002150A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooTakeCsReq Clone()
		{
			return new SpaceZooTakeCsReq(this);
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600C754 RID: 51028 RVA: 0x00216EA9 File Offset: 0x002150A9
		// (set) Token: 0x0600C755 RID: 51029 RVA: 0x00216EB1 File Offset: 0x002150B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GDCODBCDKAA
		{
			get
			{
				return this.gDCODBCDKAA_;
			}
			set
			{
				this.gDCODBCDKAA_ = value;
			}
		}

		// Token: 0x0600C756 RID: 51030 RVA: 0x00216EBA File Offset: 0x002150BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooTakeCsReq);
		}

		// Token: 0x0600C757 RID: 51031 RVA: 0x00216EC8 File Offset: 0x002150C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooTakeCsReq other)
		{
			return other != null && (other == this || (this.GDCODBCDKAA == other.GDCODBCDKAA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x00216EF8 File Offset: 0x002150F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GDCODBCDKAA != 0U)
			{
				num ^= this.GDCODBCDKAA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C759 RID: 51033 RVA: 0x00216F37 File Offset: 0x00215137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C75A RID: 51034 RVA: 0x00216F3F File Offset: 0x0021513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x00216F48 File Offset: 0x00215148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GDCODBCDKAA != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GDCODBCDKAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C75C RID: 51036 RVA: 0x00216F7C File Offset: 0x0021517C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GDCODBCDKAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GDCODBCDKAA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C75D RID: 51037 RVA: 0x00216FBA File Offset: 0x002151BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooTakeCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GDCODBCDKAA != 0U)
			{
				this.GDCODBCDKAA = other.GDCODBCDKAA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C75E RID: 51038 RVA: 0x00216FEB File Offset: 0x002151EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C75F RID: 51039 RVA: 0x00216FF4 File Offset: 0x002151F4
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
					this.GDCODBCDKAA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005084 RID: 20612
		private static readonly MessageParser<SpaceZooTakeCsReq> _parser = new MessageParser<SpaceZooTakeCsReq>(() => new SpaceZooTakeCsReq());

		// Token: 0x04005085 RID: 20613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005086 RID: 20614
		public const int GDCODBCDKAAFieldNumber = 2;

		// Token: 0x04005087 RID: 20615
		private uint gDCODBCDKAA_;
	}
}
