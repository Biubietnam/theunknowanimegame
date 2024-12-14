using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010DF RID: 4319
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetClientRaidTargetCountScRsp : IMessage<SetClientRaidTargetCountScRsp>, IMessage, IEquatable<SetClientRaidTargetCountScRsp>, IDeepCloneable<SetClientRaidTargetCountScRsp>, IBufferMessage
	{
		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600C095 RID: 49301 RVA: 0x002061E5 File Offset: 0x002043E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetClientRaidTargetCountScRsp> Parser
		{
			get
			{
				return SetClientRaidTargetCountScRsp._parser;
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600C096 RID: 49302 RVA: 0x002061EC File Offset: 0x002043EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetClientRaidTargetCountScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600C097 RID: 49303 RVA: 0x002061FE File Offset: 0x002043FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientRaidTargetCountScRsp.Descriptor;
			}
		}

		// Token: 0x0600C098 RID: 49304 RVA: 0x00206205 File Offset: 0x00204405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountScRsp()
		{
		}

		// Token: 0x0600C099 RID: 49305 RVA: 0x0020620D File Offset: 0x0020440D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountScRsp(SetClientRaidTargetCountScRsp other) : this()
		{
			this.progress_ = other.progress_;
			this.retcode_ = other.retcode_;
			this.kMGMHPKGEDA_ = other.kMGMHPKGEDA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C09A RID: 49306 RVA: 0x0020624A File Offset: 0x0020444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountScRsp Clone()
		{
			return new SetClientRaidTargetCountScRsp(this);
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600C09B RID: 49307 RVA: 0x00206252 File Offset: 0x00204452
		// (set) Token: 0x0600C09C RID: 49308 RVA: 0x0020625A File Offset: 0x0020445A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600C09D RID: 49309 RVA: 0x00206263 File Offset: 0x00204463
		// (set) Token: 0x0600C09E RID: 49310 RVA: 0x0020626B File Offset: 0x0020446B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600C09F RID: 49311 RVA: 0x00206274 File Offset: 0x00204474
		// (set) Token: 0x0600C0A0 RID: 49312 RVA: 0x0020627C File Offset: 0x0020447C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KMGMHPKGEDA
		{
			get
			{
				return this.kMGMHPKGEDA_;
			}
			set
			{
				this.kMGMHPKGEDA_ = value;
			}
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x00206285 File Offset: 0x00204485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientRaidTargetCountScRsp);
		}

		// Token: 0x0600C0A2 RID: 49314 RVA: 0x00206294 File Offset: 0x00204494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientRaidTargetCountScRsp other)
		{
			return other != null && (other == this || (this.Progress == other.Progress && this.Retcode == other.Retcode && this.KMGMHPKGEDA == other.KMGMHPKGEDA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0A3 RID: 49315 RVA: 0x002062F0 File Offset: 0x002044F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KMGMHPKGEDA != 0U)
			{
				num ^= this.KMGMHPKGEDA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x00206361 File Offset: 0x00204561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x00206369 File Offset: 0x00204569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x00206374 File Offset: 0x00204574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KMGMHPKGEDA != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.KMGMHPKGEDA);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Progress);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x002063EC File Offset: 0x002045EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KMGMHPKGEDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KMGMHPKGEDA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x0020645C File Offset: 0x0020465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientRaidTargetCountScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KMGMHPKGEDA != 0U)
			{
				this.KMGMHPKGEDA = other.KMGMHPKGEDA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x002064C0 File Offset: 0x002046C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x002064CC File Offset: 0x002046CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.Progress = input.ReadUInt32();
					}
				}
				else
				{
					this.KMGMHPKGEDA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E14 RID: 19988
		private static readonly MessageParser<SetClientRaidTargetCountScRsp> _parser = new MessageParser<SetClientRaidTargetCountScRsp>(() => new SetClientRaidTargetCountScRsp());

		// Token: 0x04004E15 RID: 19989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E16 RID: 19990
		public const int ProgressFieldNumber = 8;

		// Token: 0x04004E17 RID: 19991
		private uint progress_;

		// Token: 0x04004E18 RID: 19992
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04004E19 RID: 19993
		private uint retcode_;

		// Token: 0x04004E1A RID: 19994
		public const int KMGMHPKGEDAFieldNumber = 3;

		// Token: 0x04004E1B RID: 19995
		private uint kMGMHPKGEDA_;
	}
}
