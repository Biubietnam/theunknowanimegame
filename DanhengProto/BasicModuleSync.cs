using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000CF RID: 207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BasicModuleSync : IMessage<BasicModuleSync>, IMessage, IEquatable<BasicModuleSync>, IDeepCloneable<BasicModuleSync>, IBufferMessage
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0001B57C File Offset: 0x0001977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BasicModuleSync> Parser
		{
			get
			{
				return BasicModuleSync._parser;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0001B583 File Offset: 0x00019783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BasicModuleSyncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0001B595 File Offset: 0x00019795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BasicModuleSync.Descriptor;
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001B59C File Offset: 0x0001979C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicModuleSync()
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001B5A4 File Offset: 0x000197A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicModuleSync(BasicModuleSync other) : this()
		{
			this.weekCocoonFinishedCount_ = other.weekCocoonFinishedCount_;
			this.stamina_ = other.stamina_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0001B5D5 File Offset: 0x000197D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BasicModuleSync Clone()
		{
			return new BasicModuleSync(this);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0001B5DD File Offset: 0x000197DD
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0001B5E5 File Offset: 0x000197E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WeekCocoonFinishedCount
		{
			get
			{
				return this.weekCocoonFinishedCount_;
			}
			set
			{
				this.weekCocoonFinishedCount_ = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0001B5EE File Offset: 0x000197EE
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0001B5F6 File Offset: 0x000197F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0001B5FF File Offset: 0x000197FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BasicModuleSync);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001B60D File Offset: 0x0001980D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BasicModuleSync other)
		{
			return other != null && (other == this || (this.WeekCocoonFinishedCount == other.WeekCocoonFinishedCount && this.Stamina == other.Stamina && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0001B64C File Offset: 0x0001984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCocoonFinishedCount != 0U)
			{
				num ^= this.WeekCocoonFinishedCount.GetHashCode();
			}
			if (this.Stamina != 0U)
			{
				num ^= this.Stamina.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001B6A4 File Offset: 0x000198A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001B6AC File Offset: 0x000198AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0001B6B8 File Offset: 0x000198B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCocoonFinishedCount != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.WeekCocoonFinishedCount);
			}
			if (this.Stamina != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001B714 File Offset: 0x00019914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCocoonFinishedCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WeekCocoonFinishedCount);
			}
			if (this.Stamina != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001B76C File Offset: 0x0001996C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BasicModuleSync other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCocoonFinishedCount != 0U)
			{
				this.WeekCocoonFinishedCount = other.WeekCocoonFinishedCount;
			}
			if (other.Stamina != 0U)
			{
				this.Stamina = other.Stamina;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001B7BC File Offset: 0x000199BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001B7C8 File Offset: 0x000199C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Stamina = input.ReadUInt32();
					}
				}
				else
				{
					this.WeekCocoonFinishedCount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040003C9 RID: 969
		private static readonly MessageParser<BasicModuleSync> _parser = new MessageParser<BasicModuleSync>(() => new BasicModuleSync());

		// Token: 0x040003CA RID: 970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003CB RID: 971
		public const int WeekCocoonFinishedCountFieldNumber = 10;

		// Token: 0x040003CC RID: 972
		private uint weekCocoonFinishedCount_;

		// Token: 0x040003CD RID: 973
		public const int StaminaFieldNumber = 15;

		// Token: 0x040003CE RID: 974
		private uint stamina_;
	}
}
