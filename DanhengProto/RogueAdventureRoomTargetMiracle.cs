using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DEF RID: 3567
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomTargetMiracle : IMessage<RogueAdventureRoomTargetMiracle>, IMessage, IEquatable<RogueAdventureRoomTargetMiracle>, IDeepCloneable<RogueAdventureRoomTargetMiracle>, IBufferMessage
	{
		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x001ACAF4 File Offset: 0x001AACF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomTargetMiracle> Parser
		{
			get
			{
				return RogueAdventureRoomTargetMiracle._parser;
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x001ACAFB File Offset: 0x001AACFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetMiracleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x06009F90 RID: 40848 RVA: 0x001ACB0D File Offset: 0x001AAD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomTargetMiracle.Descriptor;
			}
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x001ACB14 File Offset: 0x001AAD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetMiracle()
		{
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x001ACB1C File Offset: 0x001AAD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetMiracle(RogueAdventureRoomTargetMiracle other) : this()
		{
			this.miracleId_ = other.miracleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x001ACB41 File Offset: 0x001AAD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomTargetMiracle Clone()
		{
			return new RogueAdventureRoomTargetMiracle(this);
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x001ACB49 File Offset: 0x001AAD49
		// (set) Token: 0x06009F95 RID: 40853 RVA: 0x001ACB51 File Offset: 0x001AAD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MiracleId
		{
			get
			{
				return this.miracleId_;
			}
			set
			{
				this.miracleId_ = value;
			}
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x001ACB5A File Offset: 0x001AAD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomTargetMiracle);
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x001ACB68 File Offset: 0x001AAD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomTargetMiracle other)
		{
			return other != null && (other == this || (this.MiracleId == other.MiracleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x001ACB98 File Offset: 0x001AAD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MiracleId != 0U)
			{
				num ^= this.MiracleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x001ACBD7 File Offset: 0x001AADD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x001ACBDF File Offset: 0x001AADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F9B RID: 40859 RVA: 0x001ACBE8 File Offset: 0x001AADE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MiracleId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x001ACC1C File Offset: 0x001AAE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MiracleId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MiracleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x001ACC5A File Offset: 0x001AAE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomTargetMiracle other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MiracleId != 0U)
			{
				this.MiracleId = other.MiracleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x001ACC8B File Offset: 0x001AAE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x001ACC94 File Offset: 0x001AAE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MiracleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400417D RID: 16765
		private static readonly MessageParser<RogueAdventureRoomTargetMiracle> _parser = new MessageParser<RogueAdventureRoomTargetMiracle>(() => new RogueAdventureRoomTargetMiracle());

		// Token: 0x0400417E RID: 16766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417F RID: 16767
		public const int MiracleIdFieldNumber = 9;

		// Token: 0x04004180 RID: 16768
		private uint miracleId_;
	}
}
