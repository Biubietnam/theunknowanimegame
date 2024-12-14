using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000541 RID: 1345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightMatch3ChatCsReq : IMessage<FightMatch3ChatCsReq>, IMessage, IEquatable<FightMatch3ChatCsReq>, IDeepCloneable<FightMatch3ChatCsReq>, IBufferMessage
	{
		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x000A47EC File Offset: 0x000A29EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightMatch3ChatCsReq> Parser
		{
			get
			{
				return FightMatch3ChatCsReq._parser;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x000A47F3 File Offset: 0x000A29F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightMatch3ChatCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x000A4805 File Offset: 0x000A2A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightMatch3ChatCsReq.Descriptor;
			}
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x000A480C File Offset: 0x000A2A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatCsReq()
		{
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x000A4814 File Offset: 0x000A2A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatCsReq(FightMatch3ChatCsReq other) : this()
		{
			this.nBPDNFMOLGO_ = other.nBPDNFMOLGO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x000A4839 File Offset: 0x000A2A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightMatch3ChatCsReq Clone()
		{
			return new FightMatch3ChatCsReq(this);
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x000A4841 File Offset: 0x000A2A41
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x000A4849 File Offset: 0x000A2A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NBPDNFMOLGO
		{
			get
			{
				return this.nBPDNFMOLGO_;
			}
			set
			{
				this.nBPDNFMOLGO_ = value;
			}
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x000A4852 File Offset: 0x000A2A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightMatch3ChatCsReq);
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x000A4860 File Offset: 0x000A2A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightMatch3ChatCsReq other)
		{
			return other != null && (other == this || (this.NBPDNFMOLGO == other.NBPDNFMOLGO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x000A4890 File Offset: 0x000A2A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NBPDNFMOLGO != 0U)
			{
				num ^= this.NBPDNFMOLGO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x000A48CF File Offset: 0x000A2ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x000A48D7 File Offset: 0x000A2AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x000A48E0 File Offset: 0x000A2AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NBPDNFMOLGO != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.NBPDNFMOLGO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x000A4914 File Offset: 0x000A2B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NBPDNFMOLGO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NBPDNFMOLGO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x000A4952 File Offset: 0x000A2B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightMatch3ChatCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NBPDNFMOLGO != 0U)
			{
				this.NBPDNFMOLGO = other.NBPDNFMOLGO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x000A4983 File Offset: 0x000A2B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x000A498C File Offset: 0x000A2B8C
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
					this.NBPDNFMOLGO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001819 RID: 6169
		private static readonly MessageParser<FightMatch3ChatCsReq> _parser = new MessageParser<FightMatch3ChatCsReq>(() => new FightMatch3ChatCsReq());

		// Token: 0x0400181A RID: 6170
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400181B RID: 6171
		public const int NBPDNFMOLGOFieldNumber = 12;

		// Token: 0x0400181C RID: 6172
		private uint nBPDNFMOLGO_;
	}
}
