using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000433 RID: 1075
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterAetherDivideSceneCsReq : IMessage<EnterAetherDivideSceneCsReq>, IMessage, IEquatable<EnterAetherDivideSceneCsReq>, IDeepCloneable<EnterAetherDivideSceneCsReq>, IBufferMessage
	{
		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x000838EC File Offset: 0x00081AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterAetherDivideSceneCsReq> Parser
		{
			get
			{
				return EnterAetherDivideSceneCsReq._parser;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x000838F3 File Offset: 0x00081AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterAetherDivideSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x00083905 File Offset: 0x00081B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAetherDivideSceneCsReq.Descriptor;
			}
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0008390C File Offset: 0x00081B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneCsReq()
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00083914 File Offset: 0x00081B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneCsReq(EnterAetherDivideSceneCsReq other) : this()
		{
			this.kEFJAPJKMGC_ = other.kEFJAPJKMGC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00083939 File Offset: 0x00081B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneCsReq Clone()
		{
			return new EnterAetherDivideSceneCsReq(this);
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x00083941 File Offset: 0x00081B41
		// (set) Token: 0x06002FCB RID: 12235 RVA: 0x00083949 File Offset: 0x00081B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEFJAPJKMGC
		{
			get
			{
				return this.kEFJAPJKMGC_;
			}
			set
			{
				this.kEFJAPJKMGC_ = value;
			}
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00083952 File Offset: 0x00081B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAetherDivideSceneCsReq);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00083960 File Offset: 0x00081B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAetherDivideSceneCsReq other)
		{
			return other != null && (other == this || (this.KEFJAPJKMGC == other.KEFJAPJKMGC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00083990 File Offset: 0x00081B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KEFJAPJKMGC != 0U)
			{
				num ^= this.KEFJAPJKMGC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000839CF File Offset: 0x00081BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000839D7 File Offset: 0x00081BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000839E0 File Offset: 0x00081BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KEFJAPJKMGC != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KEFJAPJKMGC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00083A14 File Offset: 0x00081C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KEFJAPJKMGC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEFJAPJKMGC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00083A52 File Offset: 0x00081C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAetherDivideSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KEFJAPJKMGC != 0U)
			{
				this.KEFJAPJKMGC = other.KEFJAPJKMGC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00083A83 File Offset: 0x00081C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00083A8C File Offset: 0x00081C8C
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
					this.KEFJAPJKMGC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001313 RID: 4883
		private static readonly MessageParser<EnterAetherDivideSceneCsReq> _parser = new MessageParser<EnterAetherDivideSceneCsReq>(() => new EnterAetherDivideSceneCsReq());

		// Token: 0x04001314 RID: 4884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001315 RID: 4885
		public const int KEFJAPJKMGCFieldNumber = 4;

		// Token: 0x04001316 RID: 4886
		private uint kEFJAPJKMGC_;
	}
}
