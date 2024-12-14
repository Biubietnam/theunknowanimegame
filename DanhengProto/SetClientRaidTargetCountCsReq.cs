using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010DD RID: 4317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetClientRaidTargetCountCsReq : IMessage<SetClientRaidTargetCountCsReq>, IMessage, IEquatable<SetClientRaidTargetCountCsReq>, IDeepCloneable<SetClientRaidTargetCountCsReq>, IBufferMessage
	{
		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600C07E RID: 49278 RVA: 0x00205EA9 File Offset: 0x002040A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetClientRaidTargetCountCsReq> Parser
		{
			get
			{
				return SetClientRaidTargetCountCsReq._parser;
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600C07F RID: 49279 RVA: 0x00205EB0 File Offset: 0x002040B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetClientRaidTargetCountCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600C080 RID: 49280 RVA: 0x00205EC2 File Offset: 0x002040C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetClientRaidTargetCountCsReq.Descriptor;
			}
		}

		// Token: 0x0600C081 RID: 49281 RVA: 0x00205EC9 File Offset: 0x002040C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountCsReq()
		{
		}

		// Token: 0x0600C082 RID: 49282 RVA: 0x00205ED1 File Offset: 0x002040D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountCsReq(SetClientRaidTargetCountCsReq other) : this()
		{
			this.kMGMHPKGEDA_ = other.kMGMHPKGEDA_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C083 RID: 49283 RVA: 0x00205F02 File Offset: 0x00204102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetClientRaidTargetCountCsReq Clone()
		{
			return new SetClientRaidTargetCountCsReq(this);
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600C084 RID: 49284 RVA: 0x00205F0A File Offset: 0x0020410A
		// (set) Token: 0x0600C085 RID: 49285 RVA: 0x00205F12 File Offset: 0x00204112
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600C086 RID: 49286 RVA: 0x00205F1B File Offset: 0x0020411B
		// (set) Token: 0x0600C087 RID: 49287 RVA: 0x00205F23 File Offset: 0x00204123
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

		// Token: 0x0600C088 RID: 49288 RVA: 0x00205F2C File Offset: 0x0020412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetClientRaidTargetCountCsReq);
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x00205F3A File Offset: 0x0020413A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetClientRaidTargetCountCsReq other)
		{
			return other != null && (other == this || (this.KMGMHPKGEDA == other.KMGMHPKGEDA && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x00205F78 File Offset: 0x00204178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KMGMHPKGEDA != 0U)
			{
				num ^= this.KMGMHPKGEDA.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C08B RID: 49291 RVA: 0x00205FD0 File Offset: 0x002041D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C08C RID: 49292 RVA: 0x00205FD8 File Offset: 0x002041D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x00205FE4 File Offset: 0x002041E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Progress);
			}
			if (this.KMGMHPKGEDA != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.KMGMHPKGEDA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x0020603C File Offset: 0x0020423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KMGMHPKGEDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KMGMHPKGEDA);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x00206094 File Offset: 0x00204294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetClientRaidTargetCountCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KMGMHPKGEDA != 0U)
			{
				this.KMGMHPKGEDA = other.KMGMHPKGEDA;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C090 RID: 49296 RVA: 0x002060E4 File Offset: 0x002042E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C091 RID: 49297 RVA: 0x002060F0 File Offset: 0x002042F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.KMGMHPKGEDA = input.ReadUInt32();
					}
				}
				else
				{
					this.Progress = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E0D RID: 19981
		private static readonly MessageParser<SetClientRaidTargetCountCsReq> _parser = new MessageParser<SetClientRaidTargetCountCsReq>(() => new SetClientRaidTargetCountCsReq());

		// Token: 0x04004E0E RID: 19982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0F RID: 19983
		public const int KMGMHPKGEDAFieldNumber = 12;

		// Token: 0x04004E10 RID: 19984
		private uint kMGMHPKGEDA_;

		// Token: 0x04004E11 RID: 19985
		public const int ProgressFieldNumber = 1;

		// Token: 0x04004E12 RID: 19986
		private uint progress_;
	}
}
