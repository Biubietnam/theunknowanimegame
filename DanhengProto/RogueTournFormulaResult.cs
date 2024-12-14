using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FBB RID: 4027
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournFormulaResult : IMessage<RogueTournFormulaResult>, IMessage, IEquatable<RogueTournFormulaResult>, IDeepCloneable<RogueTournFormulaResult>, IBufferMessage
	{
		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600B371 RID: 45937 RVA: 0x001E20D8 File Offset: 0x001E02D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournFormulaResult> Parser
		{
			get
			{
				return RogueTournFormulaResult._parser;
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x001E20DF File Offset: 0x001E02DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournFormulaResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600B373 RID: 45939 RVA: 0x001E20F1 File Offset: 0x001E02F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournFormulaResult.Descriptor;
			}
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x001E20F8 File Offset: 0x001E02F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaResult()
		{
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x001E2100 File Offset: 0x001E0300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaResult(RogueTournFormulaResult other) : this()
		{
			this.tournFormulaId_ = other.tournFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x001E2125 File Offset: 0x001E0325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaResult Clone()
		{
			return new RogueTournFormulaResult(this);
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600B377 RID: 45943 RVA: 0x001E212D File Offset: 0x001E032D
		// (set) Token: 0x0600B378 RID: 45944 RVA: 0x001E2135 File Offset: 0x001E0335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TournFormulaId
		{
			get
			{
				return this.tournFormulaId_;
			}
			set
			{
				this.tournFormulaId_ = value;
			}
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x001E213E File Offset: 0x001E033E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournFormulaResult);
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x001E214C File Offset: 0x001E034C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournFormulaResult other)
		{
			return other != null && (other == this || (this.TournFormulaId == other.TournFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x001E217C File Offset: 0x001E037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TournFormulaId != 0U)
			{
				num ^= this.TournFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x001E21BB File Offset: 0x001E03BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x001E21C3 File Offset: 0x001E03C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x001E21CC File Offset: 0x001E03CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TournFormulaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x001E2200 File Offset: 0x001E0400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TournFormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x001E223E File Offset: 0x001E043E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournFormulaResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TournFormulaId != 0U)
			{
				this.TournFormulaId = other.TournFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x001E226F File Offset: 0x001E046F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x001E2278 File Offset: 0x001E0478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TournFormulaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040048DA RID: 18650
		private static readonly MessageParser<RogueTournFormulaResult> _parser = new MessageParser<RogueTournFormulaResult>(() => new RogueTournFormulaResult());

		// Token: 0x040048DB RID: 18651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048DC RID: 18652
		public const int TournFormulaIdFieldNumber = 4;

		// Token: 0x040048DD RID: 18653
		private uint tournFormulaId_;
	}
}
